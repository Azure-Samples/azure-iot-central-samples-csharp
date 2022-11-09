namespace PreviewExamples {
    using Microsoft.Azure.IoTCentral.Preview.Models;
    using Microsoft.Azure.IoTCentral.Preview;
    using Azure.Core;
    using System.Text.Json;

    public class UserRoleOrgsExample {
        public static void Run(string subdomain, TokenCredential credential) {
            var usersClient = new UsersClient(subdomain, credential);
            var orgsClient = new OrganizationsClient(subdomain, credential);

            // list users with paging
            var users = usersClient.List(3);

            foreach(var page in users.AsPages()) {
                page.Values.ToList().ForEach(u => Console.WriteLine(JsonSerializer.Serialize(u, u.GetType())));
            }

            // Create a new email user
            var user = new EmailUser(new RoleAssignment[] {
                new RoleAssignment("ca310b8d-2f4a-44e0-a36e-957c202cd8d4")
            }, "user1@contoso.com");

            var createdUser = usersClient.Create("user1", user).Value;
            Console.WriteLine("Created User:");
            Console.WriteLine(JsonSerializer.Serialize(createdUser, createdUser.GetType()));

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

            // List all roles
            var rolesClient = new RolesClient(subdomain, credential);
            var roles = rolesClient.List().ToList();

            // Find org role
            var orgAdmin = roles.First(x => x.DisplayName.Contains("Org Admin"));

            // Update User's Assignment
            var roleAssignment = new RoleAssignment(orgAdmin.Id) {
                Organization = subOrg.Id
            };
            createdUser.Roles.Add(roleAssignment);
            var updatedUser = usersClient.Update("user1", createdUser).Value;
            Console.WriteLine("Updated User:");
            Console.WriteLine(JsonSerializer.Serialize(updatedUser, updatedUser.GetType()));

            // Remove a user
            var res = usersClient.Remove("user1");
            Console.WriteLine(res.Status);
        }
    }
}