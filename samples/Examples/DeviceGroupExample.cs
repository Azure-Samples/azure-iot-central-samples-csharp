using System.Text.Json;
using Microsoft.Azure.IoTCentral;
using Microsoft.Azure.IoTCentral.Models;

namespace Examples {
    public class DeviceGroupExample {
        public static void Run(AzureIoTCentral centralClient, JsonSerializerOptions options) {
            var newGroupId = "newGroupId1";

            // List all device groups
            Console.WriteLine("\nList Device Groups:");
            var groups = centralClient.DeviceGroups.List().Value;
            foreach (var group in groups)
            {
                Console.WriteLine(JsonSerializer.Serialize(group, options));
            }
            
            // Create a new group under organization group
            var newGroup = centralClient.DeviceGroups.Create(newGroupId, new DeviceGroup {
                DisplayName = "Simulated Device Group",
                Description = "Test Description",
                // If there is no capability (device property filter) using "SELECT * FROM Devices", 
                // otherwise using "SELECT * FROM {device template id} WHERE {capability name} > xxx"
                Filter = string.Format("SELECT * FROM Devices WHERE $template = \"{0}\" AND $simulated = true", Constants.TestStandardDeviceTemplateId),
                Organizations = new[] {"seattle"}
            });

            // Get Devices from group
            Console.WriteLine("\nList all devices under this group:");
            var devices = centralClient.DeviceGroups.GetDevices(newGroupId).Value;
            devices.ToList().ForEach(d => Console.WriteLine(d.DisplayName));

            var retrieved = centralClient.DeviceGroups.Get(newGroupId);
            Console.WriteLine(JsonSerializer.Serialize(retrieved, options));

            // Update group displayName
            Console.WriteLine("\nUpdate Device Group:");
            var updated = centralClient.DeviceGroups.Update(newGroupId, new DeviceGroup {
                DisplayName = "Simulated - Update"
            });
            Console.WriteLine(JsonSerializer.Serialize(updated, options));

            // Delete Device Group
            centralClient.DeviceGroups.Remove(newGroupId);
        }
    }
}