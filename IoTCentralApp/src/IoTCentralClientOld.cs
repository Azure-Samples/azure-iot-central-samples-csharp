using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.IotCentral.Models;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Azure.Management.ResourceManager.Fluent.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using Newtonsoft.Json.Linq;

namespace IoTCentralApp
{
    public class IoTCentralClientOld
    {
        private AzureCredentials credentials;
        private IAzure azure;
        private string iotCentralResourceName;

        public async Task RunAsync()
        {
            await this.CreateTokenWithADALAsync("ddf282ff-2480-4e56-851c-482371791228", "72f988bf-86f1-41af-91ab-2d7cd011db47");
            // this.CreateAzureClient("ddf282ff-2480-4e56-851c-482371791228", "/GuB=jeTjL1Y5UR6TtA7w@h/T61?815.", "72f988bf-86f1-41af-91ab-2d7cd011db47", "faab228d-df7a-4086-991e-e81c4659d41a");
            this.iotCentralResourceName = "juntest0110-02-portal";
            // this.DeployIotCentralAppUsingARMTemplate("juntest0110-01", "iotc-condition@1.0.0");
            //await this.DeployIotCentralAppUsingARMTemplate2Async(this.iotCentralResourceName);
            // await this.AcquireTokenAsync();
        }

        public async Task CreateTokenWithADALAsync(string clientId, string tenant) {
            clientId = "61d65f5a-6e3b-468b-af73-a033f5098c5c"; // azure-tools-for-java
            var resource = "https://management.core.windows.net";
            var resource2 = "https://apps.azureiotcentral.com";

            AuthenticationContext context = new AuthenticationContext("https://login.microsoftonline.com/common", true);
            var deviceCode = await context.AcquireDeviceCodeAsync(resource, clientId).ConfigureAwait(false);
            Console.ResetColor();
            Console.WriteLine("You need to sign in.");
            Console.WriteLine("Message: " + deviceCode.Message + "\n");
            var result = await context.AcquireTokenByDeviceCodeAsync(deviceCode).ConfigureAwait(false);
            Console.WriteLine(result.AccessToken);

            var result2 = await context.AcquireTokenSilentAsync(resource2, clientId);
            Console.WriteLine(result2.AccessToken);
        }

        public void CreateAzureClient(string client, string key, string tenant, string subscriptionId)
        {
            // this.credentials = SdkContext.AzureCredentialsFactory.FromServicePrincipal(client, key, tenant, AzureEnvironment.AzureGlobalCloud);
            // client = "6b6947ca-c26c-4fe4-bdf4-f28c6494b5d1";
            // tenant = "645d490f-7a6a-429e-a624-037110319f4d";
            // subscriptionId = "0e155f21-f386-47fd-844b-1352680964cf";
            // client = "aebc6443-996d-45c2-90f0-388ff96faa56"; // VS Code Azure Account
            client = "61d65f5a-6e3b-468b-af73-a033f5098c5c"; // azure-tools-for-java
            //client = "6b6947ca-c26c-4fe4-bdf4-f28c6494b5d1"; // formulahendry
            //tenant = "645d490f-7a6a-429e-a624-037110319f4d"; // formulahendry
            // subscriptionId = "0e155f21-f386-47fd-844b-1352680964cf"; // formulahendry
            tenant = "common";
            this.credentials = SdkContext.AzureCredentialsFactory.FromDevice(client, tenant, AzureEnvironment.AzureGlobalCloud, code =>
                {
                    Console.WriteLine(code.Message);
                    return true;
                });
            this.azure = Azure.Authenticate(this.credentials).WithSubscription(subscriptionId);
            var rgs = this.azure.ResourceGroups.List();
            foreach (var rg in rgs)
            {
                Console.WriteLine(rg.Name);
            }
        }

        public void DeployIotCentralAppUsingARMTemplate(string resourceName, string template)
        {
            var rgName = "rgrsat95747993e08bd";
            // var rgName = SdkContext.RandomResourceName("rgRSAT", 24);
            // Console.WriteLine("Creating a resource group with name: " + rgName);
            // this.azure.ResourceGroups.Define(rgName)
            //         .WithRegion(Region.USCentral)
            //         .Create();
            // Console.WriteLine("Created a resource group with name: " + rgName);

            this.iotCentralResourceName = resourceName;
            var deploymentName = SdkContext.RandomResourceName("dpRSAT", 24);
            var armTemplateString = File.ReadAllText("resources/template.json");
            JObject parametersObject = new JObject(
                    new JProperty("resourceName",
                        new JObject(
                            new JProperty("value", resourceName)
                        )
                    ),
                    new JProperty("template",
                        new JObject(
                            new JProperty("value", template)
                        )
                    )
                );
            // var parameters = "{\"resourceName\":{\"value\":\"" + resourceName + "\"},\"template\":{\"value\":\"" + template + "\"}}";
            Console.WriteLine("Starting a deployment for an Azure IoT Central Application: " + deploymentName);
            azure.Deployments.Define(deploymentName)
                .WithExistingResourceGroup(rgName)
                .WithTemplate(armTemplateString)
                .WithParameters(parametersObject)
                .WithMode(DeploymentMode.Incremental)
                .Create();
            Console.WriteLine("Completed the deployment: " + deploymentName);
        }


        public async Task DeployIotCentralAppUsingIotCentralSDK(string resourceName)
        {
            var client = new Microsoft.Azure.Management.IotCentral.IotCentralClient(this.credentials);
            var skuInfo = new AppSkuInfo("S1");
            var app = new App("unitedstates", skuInfo);
            client.SubscriptionId = "faab228d-df7a-4086-991e-e81c4659d41a";

            var rgName = "rgrsat95747993e08bd";

            app.Location = "unitedstates";
            app.Subdomain = resourceName;
            app.DisplayName = resourceName;
            app.Template = "iotc-condition@1.0.0";

            Console.WriteLine("Creating app");
            var resultApp = await client.Apps.CreateOrUpdateWithHttpMessagesAsync(rgName, resourceName, app);

            Console.WriteLine("Listing apps");
            var apps = await client.Apps.ListByResourceGroupWithHttpMessagesAsync(rgName);
            Console.WriteLine(apps.ToString());

            var request = new HttpRequestMessage(HttpMethod.Get, $"https://{this.iotCentralResourceName}.azureiotcentral.com/api/preview/devices");
            var cancellationToken = new CancellationToken();
            await client.Credentials.ProcessHttpRequestAsync(request, cancellationToken);
            var httpClient = new HttpClient();
            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
        }

        public async Task AcquireTokenAsync()
        {
            var client = RestClient
                .Configure()
                .WithEnvironment(AzureEnvironment.AzureGlobalCloud)
                .WithCredentials(this.credentials)
                .Build();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://{this.iotCentralResourceName}.azureiotcentral.com/api/preview/devices");
            var cancellationToken = new CancellationToken();
            await client.Credentials.ProcessHttpRequestAsync(request, cancellationToken);
            var httpClient = new HttpClient();
            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
        }
    }
}
