using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using IoTCentral;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;

namespace IoTCentralApp
{
    public class IoTCentralClient
    {
        private string AccessTokenAzure;
        private string AccessTokenIoTCentral;
        private HttpClient httpClientIoTAzure;
        private HttpClient httpClientIoTCentral;
        private DeviceTemplatesClient deviceTemplatesClient;
        private DevicesClient devicesClient;
        private string subscriptionId;
        private string resourceGroupName;
        private string iotCentralResourceName;
        private string deviceTemplateId;
        private string deviceId;

        private class AccessToken
        {
            public string refreshToken { get; set; }
            public string resource { get; set; }
        }

        public string SubscriptionId { set => subscriptionId = value; }
        public string ResourceGroupName { set => resourceGroupName = value; }

        public async Task RunAsync()
        {
            await this.CreateTokenWithADALAsync();
            this.iotCentralResourceName = "juntest0119-02-new-sdk";
            this.initilizeHttpClientAzure();
            await this.DeployIotCentralAppUsingARMTemplate("juntest0119-02-new-sdk", "iotc-condition@1.0.0");
            this.initilizeHttpClientIoTCentral();
            await this.CreateDeviceTemplate(Path.Combine(System.AppContext.BaseDirectory, "resources", "deviceTemplate.json"));
            await this.CreateDevice("deviceId6");
            await this.GetDeviveTelemetry("deviceId6", "S1_Sensor", "temperature");
        }

        public async Task ParseTokenFromAzureCli()
        {
            var accessTokensFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".azure", "accessTokens.json");
            string accessTokens = File.ReadAllText(accessTokensFilePath);
            var accessTokensArray = Newtonsoft.Json.JsonConvert.DeserializeObject<AccessToken[]>(accessTokens);

            this.AccessTokenAzure = await this.getRefreshedAccessToken(accessTokensArray, "https://management.core.windows.net");
            this.AccessTokenIoTCentral = await this.getRefreshedAccessToken(accessTokensArray, "https://apps.azureiotcentral.com");
        }

        public async Task CreateTokenWithADALAsync()
        {
            // var clientId = "6b6947ca-c26c-4fe4-bdf4-f28c6494b5d1"; // formulahendry
            var clientId = "61d65f5a-6e3b-468b-af73-a033f5098c5c"; // azure-tools-for-java
            // var clientId = "aebc6443-996d-45c2-90f0-388ff96faa56"; // VS Code Azure Account
            var resource = "https://management.core.windows.net";
            var resource2 = "https://apps.azureiotcentral.com";

            AuthenticationContext context = new AuthenticationContext("https://login.microsoftonline.com/common", true);
            // AuthenticationContext context = new AuthenticationContext("https://login.microsoftonline.com/645d490f-7a6a-429e-a624-037110319f4d", true); // formulahendry
            var deviceCode = await context.AcquireDeviceCodeAsync(resource, clientId).ConfigureAwait(false);
            Console.ResetColor();
            Console.WriteLine("You need to sign in.");
            Console.WriteLine("Message: " + deviceCode.Message + "\n");
            var result = await context.AcquireTokenByDeviceCodeAsync(deviceCode).ConfigureAwait(false);
            this.AccessTokenAzure = result.AccessToken;

            var result2 = await context.AcquireTokenSilentAsync(resource2, clientId);
            this.AccessTokenIoTCentral = result2.AccessToken;
        }

        public void initilizeHttpClientAzure()
        {
            this.httpClientIoTAzure = new HttpClient();
            httpClientIoTAzure.DefaultRequestHeaders.Add("Authorization", $"Bearer {this.AccessTokenAzure}");
        }

        public async Task<string> GetSubscriptions()
        {
            var uri = new Uri($"https://management.azure.com/subscriptions?api-version=2019-10-01");
            var result = await this.httpClientIoTAzure.GetAsync(uri);
            return await result.Content.ReadAsStringAsync();
        }

        public async Task CreateResourceGroup(string resourceGroupName)
        {
            var uri = new Uri($"https://management.azure.com/subscriptions/{this.subscriptionId}/resourcegroups/{resourceGroupName}?api-version=2019-10-01");
            var requestBody = @"{
                    ""location"": ""westus""
                }";
            var result = await this.httpClientIoTAzure.PutAsync(uri, new StringContent(requestBody, System.Text.Encoding.UTF8, "application/json"));
            Console.WriteLine(await result.Content.ReadAsStringAsync());
        }

        public async Task<string> GetResourceGroups()
        {
            var uri = new Uri($"https://management.azure.com/subscriptions/{this.subscriptionId}/resourcegroups?api-version=2019-10-01");
            var result = await this.httpClientIoTAzure.GetAsync(uri);
            return await result.Content.ReadAsStringAsync();
        }

        public async Task DeployIotCentralAppUsingARMTemplate(string resourceName, string template)
        {
            this.iotCentralResourceName = resourceName;

            var deploymentName = Utility.RandomResourceName("deploy", 8);
            var uri = new Uri($"https://management.azure.com/subscriptions/{this.subscriptionId}/resourcegroups/{this.resourceGroupName}/providers/Microsoft.Resources/deployments/{deploymentName}?api-version=2019-10-01");

            string armBody = File.ReadAllText(Path.Combine(System.AppContext.BaseDirectory, "resources", "armBody.json"));
            dynamic armBodyObj = Newtonsoft.Json.JsonConvert.DeserializeObject(armBody);
            armBodyObj["properties"]["parameters"]["resourceName"]["value"] = resourceName;
            armBodyObj["properties"]["parameters"]["template"]["value"] = template;
            string newArmBody = JsonConvert.SerializeObject(armBodyObj, Formatting.Indented);

            Console.WriteLine(newArmBody);

            Console.WriteLine("Starting a deployment for an Azure IoT Central Application: " + deploymentName);
            var result = await this.httpClientIoTAzure.PutAsync(uri, new StringContent(newArmBody, System.Text.Encoding.UTF8, "application/json"));
            Console.WriteLine(await result.Content.ReadAsStringAsync());
            Console.WriteLine("Started the deployment: " + deploymentName);

            uri = new Uri($"https://management.azure.com/subscriptions/{this.subscriptionId}/resourcegroups/{this.resourceGroupName}/providers/Microsoft.Resources/deployments/{deploymentName}?api-version=2019-10-01");
            while (true)
            {
                result = await this.httpClientIoTAzure.GetAsync(uri);
                var resultString = await result.Content.ReadAsStringAsync();
                dynamic resultObj = Newtonsoft.Json.JsonConvert.DeserializeObject(resultString);
                var provisioningState = (string)resultObj["properties"]["provisioningState"];
                if (provisioningState == "Succeeded")
                {
                    Console.WriteLine();
                    Console.WriteLine($"IoT Central [{resourceName}] is deployed.");
                    break;
                }
                if (provisioningState != "Accepted" && provisioningState != "Running")
                {
                    Console.WriteLine();
                    Console.WriteLine("Deployment failed.");
                    throw new System.Exception(resultString);
                }
                Console.Write(".");
                System.Threading.Thread.Sleep(2000);
            }
        }

        public void initilizeHttpClientIoTCentral()
        {
            this.httpClientIoTCentral = new HttpClient();
            httpClientIoTCentral.DefaultRequestHeaders.Add("Authorization", $"Bearer {this.AccessTokenIoTCentral}");

            var baseUrl = $"https://{this.iotCentralResourceName}.azureiotcentral.com/api/preview";
            this.deviceTemplatesClient = new DeviceTemplatesClient(this.httpClientIoTCentral);
            this.deviceTemplatesClient.BaseUrl = baseUrl;
            this.devicesClient = new DevicesClient(this.httpClientIoTCentral);
            this.devicesClient.BaseUrl = baseUrl;
        }

        public async Task CreateDeviceTemplate(string templateFilePath)
        {
            string template = File.ReadAllText(templateFilePath);
            var templateObject = Newtonsoft.Json.JsonConvert.DeserializeObject<DeviceTemplate>(template);

            this.deviceTemplateId = templateObject.Id;
            var result = await deviceTemplatesClient.SetAsync(templateObject, templateObject.Id);

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);
        }

        public async Task CreateDevice(string deviceId)
        {
            this.deviceId = deviceId;

            var device = new Device();
            device.Id = deviceId;
            device.DisplayName = deviceId;
            device.InstanceOf = this.deviceTemplateId;
            device.Simulated = true;
            var result = await this.devicesClient.SetAsync(device, deviceId);

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);
        }

        public async Task GetDeviveTelemetry(string deviceId, string componentName, string telemetryName)
        {
            var result = await this.devicesClient.GetTelemetryValueAsync(deviceId, componentName, telemetryName);

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);
        }

        private async Task<string> getRefreshedAccessToken(AccessToken[] accessTokensArray, string resouce)
        {
            var refreshToken = this.getRefreshTokenByResource(accessTokensArray, resouce);
            if (String.IsNullOrWhiteSpace(refreshToken)) {
                Console.WriteLine($"Did not find Refresh Token of '{resouce}'. Please run below commands and then try agaon:");
                Console.WriteLine(">> az login");
                Console.WriteLine(">> az account get-access-token --resource https://apps.azureiotcentral.com");
                Environment.Exit(1);
            }
            var httpClient = new HttpClient();
            var values = new Dictionary<string, string>
                {
                    {"client_id", "04b07795-8ddb-461a-bbee-02f9e1bf7b46"},
                    {"refresh_token", refreshToken},
                    {"grant_type", "refresh_token"},
                    {"resource", resouce},
                };
            var result = await httpClient.PostAsync("https://login.microsoftonline.com/common/oauth2/token", new FormUrlEncodedContent(values));
            var resultString = await result.Content.ReadAsStringAsync();
            if (result.StatusCode != HttpStatusCode.OK) {
                throw new Exception(resultString);
            }
            dynamic resultObj = Newtonsoft.Json.JsonConvert.DeserializeObject(resultString);
            Console.WriteLine(resultObj["access_token"]);
            // string json = JsonConvert.SerializeObject(await result.Content.ReadAsStringAsync(), Formatting.Indented);
            // Console.WriteLine(json);
            // Console.WriteLine(await result.Content.ReadAsStringAsync());
            return (string)resultObj["access_token"];
        }

        private string getRefreshTokenByResource(AccessToken[] accessTokensArray, string resouce)
        {
            foreach (var accessToken in accessTokensArray)
            {
                if (accessToken.resource.StartsWith(resouce))
                {
                    return (string)accessToken.refreshToken;
                }
            }
            return "";
        }
    }
}
