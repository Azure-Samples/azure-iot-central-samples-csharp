using System.Text.Json;
using Microsoft.Azure.IoTCentral;
using Microsoft.Azure.IoTCentral.Models;
using Newtonsoft.Json;

namespace Examples {
    public class DeviceTemplateExample {
        public static void Run(AzureIoTCentral centralClient, JsonSerializerOptions options) {
            // Create an device template
            var fileBytes = File.ReadAllBytes(@"files/deviceTemplate.json");
            var payload = JsonConvert.DeserializeObject<DeviceTemplate>(File.ReadAllText(@"files/deviceTemplate.json"));
            var template = centralClient.DeviceTemplates.Create(Constants.TestStandardDeviceTemplateId, payload);

            Console.WriteLine("\nDevice Tempalte Created:");
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(new { id = template.Id, displayName = template.DisplayName, type = template.Type }));

            // List Device Templates
            var templates = centralClient.DeviceTemplates.List().Value;
            Console.WriteLine("\nList all templates from app:");
            templates.ToList().ForEach(t => Console.WriteLine(t.DisplayName));

            // Known issues: Update template, had limitations on remove or update existed capability as there is default view generated reference these capabilities.
            // You can add new capability, you also can update the displayName.            
        }
    }
}