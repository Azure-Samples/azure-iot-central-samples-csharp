using System.Text.Json;
using Microsoft.Azure.IoTCentral;
using Microsoft.Azure.IoTCentral.Models;

namespace Examples {
    public class UserOrgExample {
        public static void Run(AzureIoTCentral centralClient, JsonSerializerOptions options) {
            // Create an organization
            var orgCreated = centralClient.Organizations.Create("seattle", new Organization {
                DisplayName = "Seattle Branch",
            });

            centralClient.Organizations.Create("bellevue", new Organization {
                DisplayName = "Bellevue Branch",
                Parent = "seattle"
            });

            Console.WriteLine("List all orgs:");
            var orgs = centralClient.Organizations.List().Value;
            orgs.ToList().ForEach(o => Console.WriteLine(JsonSerializer.Serialize(o, o.GetType(), options)));

            // Create an user

            Console.WriteLine("\nList all roles:");
            var roles = centralClient.Roles.List();
            roles.Value.ToList().ForEach(x => Console.WriteLine(JsonSerializer.Serialize(x, x.GetType(), options)));
            
            var newUser = centralClient.Users.Create("testuser1", new EmailUser {
                Email = "test1@contoso.com",
                Roles = new[] { new RoleAssignment { Role = roles.Value.FirstOrDefault(x => x.DisplayName.Contains("Org")).Id, Organization = "seattle" } }
            });

            Console.WriteLine($"\nNew user created:");
            Console.WriteLine(JsonSerializer.Serialize(newUser, newUser.GetType(), options));

            Console.WriteLine("\nList all users:");
            var users = centralClient.Users.List().Value;
            users.ToList().ForEach(u => Console.WriteLine(JsonSerializer.Serialize(u, u.GetType(), options)));

            // Update User
            newUser = centralClient.Users.Update("testuser1", new { Roles = new[] {
                    new RoleAssignment { Role = roles.Value.FirstOrDefault(x => x.DisplayName.Contains("Org")).Id, Organization = "seattle" },
                    new RoleAssignment { Role = roles.Value[0].Id }
                }
            });

            Console.WriteLine("\nUpdated User:");
            Console.WriteLine(JsonSerializer.Serialize(newUser, newUser.GetType(), options));

            // Delete User
            centralClient.Users.Remove("testuser1");

            // Delete Organization
            centralClient.Organizations.Remove("bellevue");
        }
    }
}