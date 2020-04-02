using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Azure.Management.Subscription;
using Microsoft.Azure.Management.Subscription.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace IoTCentralApp
{
    public class IoTCentralConsole
    {
        private IoTCentralClient client;

        public class SubscriptionListResult
        {
            public IList<Subscription> value { get; set; }
        }

        public class Subscription
        {
            public string subscriptionId { get; set; }
            public string displayName { get; set; }
        }

        public class ResourceGroupListResult
        {
            public IList<ResourceGroup> value { get; set; }
        }

        public class ResourceGroup
        {
            public string name { get; set; }
            public string location { get; set; }
        }


        public IoTCentralConsole()
        {
            this.client = new IoTCentralClient();
        }

        public async Task RunAsync()
        {
            await this.client.ParseTokenFromAzureCli();

            // await this.client.CreateTokenWithADALAsync();

            this.client.initilizeHttpClientAzure();

            await this.SelectSubscription();

            await this.CreateOrSelectResourceGroup();

            await this.DeployIotCentralApp();

            this.client.initilizeHttpClientIoTCentral();

            await this.CreateDeviceTemplate();

            var deviceId = Utility.getInputValue("Device ID");
            Console.WriteLine("Creating Device...");
            await this.client.CreateDevice(deviceId);

            Console.WriteLine("Getting Devive Telemetry...");
            var componentName = Utility.getInputValue("Component Name"); // "Interface"
            var telemetryName = Utility.getInputValue("Telemetry Name"); // "Temperature"
            await this.client.GetDeviveTelemetry(deviceId, componentName, telemetryName);
        }

        public async Task SelectSubscription()
        {
            Console.WriteLine("Querying Subscriptions...");
            var subscriptionListResultString = await this.client.GetSubscriptions();
            var subscriptionListResult = JsonConvert.DeserializeObject<SubscriptionListResult>(subscriptionListResultString);
            var subscriptions = subscriptionListResult.value;
            Console.WriteLine("[Subscription ID]\t[Display Name]");
            var subscriptionList = new List<string>();
            foreach (var subscription in subscriptions)
            {
                subscriptionList.Add(String.Format($"{subscription.subscriptionId}\t{subscription.displayName}"));
            }
            var subscriptionString = Utility.selectFromArray(subscriptionList, "Pick a Subscription:");
            this.client.SubscriptionId = subscriptionString.Split('\t')[0];
        }

        public async Task CreateOrSelectResourceGroup()
        {
            if (Utility.getAnswerOfYesOrNo("Create a new Resource Group"))
            {
                await this.CreateResourceGroup();
            }
            else
            {
                await this.SelectResourceGroup();
            }
        }

        public async Task CreateResourceGroup()
        {
            var resourceGroupName = Utility.getInputValue("Resource Group Name");
            await this.client.CreateResourceGroup(resourceGroupName);
            this.client.ResourceGroupName = resourceGroupName;
        }

        public async Task SelectResourceGroup()
        {
            Console.WriteLine("Querying Resource Groups...");
            var resourceGroupListResultString = await this.client.GetResourceGroups();
            var resourceGroupListResult = JsonConvert.DeserializeObject<ResourceGroupListResult>(resourceGroupListResultString);
            var resourceGroups = resourceGroupListResult.value;
            Console.WriteLine("[Name]\t[Location]");
            var resourceGroupList = new List<string>();
            foreach (var rg in resourceGroups)
            {
                resourceGroupList.Add($"{rg.name}\t{rg.location}");
            }
            var resourceGroupString = Utility.selectFromArray(resourceGroupList, "Pick a Resource Group:");
            this.client.ResourceGroupName = resourceGroupString.Split('\t')[0];
        }

        public async Task DeployIotCentralApp()
        {
            var iotCentralResourceName = "";
            var regex = new Regex(@"^[a-z0-9]+[a-z0-9-]*[a-z0-9]+$");
            while (true)
            {
                iotCentralResourceName = Utility.getInputValue("IoT Central Resource Name");
                if (regex.IsMatch(iotCentralResourceName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The valid resource name characters include [a-z], [0-9], and '-'");
                }
            }
            await this.client.DeployIotCentralAppUsingARMTemplate(iotCentralResourceName, "iotc-pnp-preview@1.0.0");
        }

        public async Task CreateDeviceTemplate()
        {
            Console.WriteLine("Creating Device Template...");
            Console.Write($"Please enter file path of Device Template (leave blank to use default template): ");
            var templateFilePath = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(templateFilePath))
            {
                templateFilePath = Path.Combine(System.AppContext.BaseDirectory, "resources", "deviceTemplate.json");
            }
            await this.client.CreateDeviceTemplate(templateFilePath);
        }
    }
}