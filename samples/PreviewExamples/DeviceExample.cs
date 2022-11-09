namespace PreviewExamples {
    using System.Text.Json;
    using Azure.Core;
    using Microsoft.Azure.IoTCentral.Preview;
    using Microsoft.Azure.IoTCentral.Preview.Models;

    // Device Examples from preview API

    public class DeviceExample {
        public static void Run(string subdomain, TokenCredential credential) {
            var devicesClient = new DevicesClient(subdomain, credential);

            // Demo new functions for filter, paging, orderby

            // Create list of edge Devices
            for (int i = 0; i < 5; i++) {
                var deviceId = $"testdevice_{i}";
                if (devicesClient.Get(deviceId).GetRawResponse().Status == 404) {
                    var device = new Device();
                    device.DisplayName = $"test device {i}";
                    device.Enabled = false;
                    device.Simulated = false;
                    device.Type.Add(DeviceType.IotEdge);
                    devicesClient.Create(deviceId, device);
                }
                Thread.Sleep(100);
            }

            // List edge devices
            var edgeDevices = devicesClient.List("contains(type, 'iotEdge') and id eq 'testdevice_1'").ToList();

            Console.WriteLine($"Device found {edgeDevices.Count}");
            Console.WriteLine(JsonSerializer.Serialize(edgeDevices.First(), edgeDevices.First().GetType()));

            // Update edge devices with orgs
            var orgsClient = new OrganizationsClient(subdomain, credential);
            var orgs = orgsClient.List().ToList();
            if(orgs.Count < 1) {
                Console.WriteLine("No organizations listed:");

                // Create an organization
                var org = new Organization {
                    DisplayName = "Washington"
                };                
                var createdOrg = orgsClient.Create("washington", org).Value;
                Console.WriteLine("Created Org:");
                Console.WriteLine(JsonSerializer.Serialize(createdOrg, createdOrg.GetType()));

                // Create an organization under washington
                var subOrg = orgsClient.Create("seattle", new Organization {
                    DisplayName = "Seattle",
                    Parent = "washington"
                }).Value;
                Console.WriteLine("Created Sub Org:");
                Console.WriteLine(JsonSerializer.Serialize(subOrg, subOrg.GetType()));
                orgs.AddRange(new [] {createdOrg, subOrg});
            }

            // Update Devices Orgs
            var edgeDevice = edgeDevices.First();
            edgeDevice.Type.Clear(); // clear type as it can't be updated.
            edgeDevice.Organizations.Clear();
            edgeDevice.Organizations.Add(orgs.FirstOrDefault().Id);
            var updatedDevice = devicesClient.Update(edgeDevice.Id, edgeDevice).Value;
            Console.WriteLine("Device get updated with orgs:");
            Console.WriteLine(JsonSerializer.Serialize(updatedDevice, updatedDevice.GetType()));

            // Add a deployment manifest
            var manifestsClient = new DeploymentManifestsClient(subdomain, credential);
            var manifests = manifestsClient.List().ToList();
            var manifest = new DeploymentManifest(JsonSerializer.Deserialize<dynamic>(File.ReadAllText(@"files/deploymentManifest.json")));
            Console.WriteLine(JsonSerializer.Serialize(manifest, manifest.GetType()));
            if(manifests.Count == 0) {
                // Create a new deployment manifest
                var createdManifest = manifestsClient.Create("testmanifest1", manifest);
                Console.WriteLine("Deployment Manifest Created:");
                Console.WriteLine(JsonSerializer.Serialize(createdManifest, createdManifest.GetType()));
            }

            // Apply Manifest to Edge Device
            devicesClient.ApplyManifest(edgeDevice.Id, manifest);
            Console.WriteLine("Deployment Manifest applied to device");

            // Get device with deployment manifest
            var deviceWithManifest = devicesClient.Get(edgeDevice.Id, expand: "deploymentManifest");
            Console.WriteLine(JsonSerializer.Serialize(deviceWithManifest, deviceWithManifest.GetType()));
        }
    }
}