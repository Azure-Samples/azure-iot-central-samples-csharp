using System.Security.Cryptography;
using System.Text.Json;
using Microsoft.Azure.IoTCentral;
using Microsoft.Azure.IoTCentral.Models;

namespace Examples {
    public class DeviceExample {
        public static void Run(AzureIoTCentral centralClient, JsonSerializerOptions options) {
            // Add Device
            Console.WriteLine("\nStart to adding Device:");
            Console.WriteLine("\nPlease Input your device Id:");
            var deviceId = Console.ReadLine();
            while(string.IsNullOrWhiteSpace(deviceId)) {
                Console.WriteLine("\nDevice ID can't be null or empty string");
                deviceId = Console.ReadLine();
            }

            var newDevice = centralClient.Devices.Create(deviceId, new Device {
                DisplayName = "Test 1",
                Template = Constants.TestStandardDeviceTemplateId,
                Enabled = true,
                Simulated = true,
                Organizations = new[] {"seattle"}
            });

            Console.WriteLine("\nDevice created:");
            Console.WriteLine(JsonSerializer.Serialize(newDevice, options));

            // Wait until device get provisioned to proceed.
            while(newDevice.Provisioned == false) {
                newDevice = centralClient.Devices.Get(deviceId);
            }

            Console.WriteLine("\nDevice provisioned successfully");

            
            // Update Device
            Console.WriteLine("\nStart to update Device Name:");
            newDevice = centralClient.Devices.Update(deviceId, new Device {
                DisplayName = "Device - new Update"
            });

            Console.WriteLine("\nFinished to Update Device:");
            Console.WriteLine(JsonSerializer.Serialize(newDevice, options));

            // Get Device Credential - Simulated Device can't get credentials
            var unSimulatedDeviceId = "unsim1";
            centralClient.Devices.Create(unSimulatedDeviceId, new Device {
                DisplayName = "UnSim-Device",
                Enabled = true,
            });
            var credentials = centralClient.Devices.GetCredentials(unSimulatedDeviceId);
            Console.WriteLine("\nDevice credential retrieved, unsimulated device only!");
            Console.WriteLine(JsonSerializer.Serialize(credentials, options));

            // Create Device attestation - unsimulated device id only
            Aes aes = Aes.Create();
            aes.GenerateIV();
            aes.GenerateKey();
            var primaryKey = Convert.ToBase64String(aes.Key);
            aes.GenerateIV();
            aes.GenerateKey();
            var secondaryKey = Convert.ToBase64String(aes.Key);
            Console.WriteLine($"Primary Key: {primaryKey}");
            Console.WriteLine($"Secondary Key: {secondaryKey}");

            var attestation = centralClient.Devices.CreateAttestation(unSimulatedDeviceId, new SymmetricKeyAttestation {
                SymmetricKey = new SymmetricKey {
                    PrimaryKey = primaryKey,
                    SecondaryKey = secondaryKey
                }
            });
            Console.WriteLine("\nDevice Symmetric Key Attestation Created - unsimulated device only!");
            Console.WriteLine(JsonSerializer.Serialize((SymmetricKeyAttestation)attestation, options));

            // Update Device Root Properties
            Console.WriteLine("\nUpdating Device root properties");
            centralClient.Devices.UpdateProperties(deviceId, new {
                RootStringWritableProperty = "test"
            });
            var properties = centralClient.Devices.GetProperties(deviceId);
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(properties, Newtonsoft.Json.Formatting.Indented));

            // List Device Components
            Console.WriteLine("\nList Device components:");
            var components = centralClient.Devices.ListComponents(deviceId).Value;
            components.ToList().ForEach(c => Console.WriteLine(((Newtonsoft.Json.Linq.JObject)c).GetValue("name")));

            // Get Device Component Properties
            Console.WriteLine("\nGet Device Component Properties:");
            var componentProperties = centralClient.Devices.GetComponentProperties(deviceId, "settings");
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(componentProperties, Newtonsoft.Json.Formatting.Indented));

            // Run Device Root Command
            Console.WriteLine("\nRun Device Command:");
            centralClient.Devices.RunCommand(deviceId, "RootQueuedCommand", new DeviceCommand {
                Request = new Dictionary<string, object> { {"Threshold", 10} }
            });

            var history = centralClient.Devices.GetCommandHistory(deviceId, "RootQueuedCommand");
            Console.WriteLine(JsonSerializer.Serialize(history, options));

            // Get Device Telemetry Value
            Console.WriteLine("\nGet Device Telemetry");
            var lkv = centralClient.Devices.GetTelemetryValue(deviceId, "RootLocationTelemetry");
            Console.WriteLine(JsonSerializer.Serialize(history, options));

            // Disable Device
            Console.WriteLine("\nDiable Device:");
            newDevice = centralClient.Devices.Update(deviceId, new Device {Enabled = false});
            Console.WriteLine(JsonSerializer.Serialize(newDevice, options));

            // List Devices
            Console.WriteLine("\nList all devices:");
            var devices = centralClient.Devices.List().Value;
            devices.ToList().ForEach(d => Console.WriteLine(JsonSerializer.Serialize(d)));

            // Remove Device
            Console.WriteLine("\nRemoving the device:");
            centralClient.Devices.Remove(deviceId);
            centralClient.Devices.Remove(unSimulatedDeviceId);
            Console.WriteLine("\nDevice removed");
        }
    }
}