using System.Text.Json;
using Microsoft.Azure.IoTCentral;
using Microsoft.Azure.IoTCentral.Models;
using Newtonsoft.Json;

namespace Examples {
    public class EnrollmentGroupExample {
        public static void Run(AzureIoTCentral centralClient, JsonSerializerOptions options) {
            // List all enrollment groups
            Console.WriteLine("\nList all Enrollment Groups:");
            var egroups = centralClient.EnrollmentGroups.List().Value;
            egroups.ToList().ForEach(g => Console.WriteLine(JsonConvert.SerializeObject(g, Formatting.Indented)));

            // Create new Enrollment Group
            var newGroupId = "newGroupId1";
            var newGroup = centralClient.EnrollmentGroups.Create(newGroupId, new EnrollmentGroup {
                DisplayName = "Created New Group",
                Type = EnrollmentGroupType.IoTdevices,
                Attestation = new GroupSymmetricKeyAttestation {
                    SymmetricKey = null
                }
            });

            Console.WriteLine("\nNew SymmetricKey Group created for IoT Devices");
            Console.WriteLine(JsonConvert.SerializeObject(newGroup, Formatting.Indented));

            //Delete Enrollment Group
            centralClient.EnrollmentGroups.Remove(newGroupId);
        }
    }
}