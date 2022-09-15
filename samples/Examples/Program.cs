using System.Text.Json;
using Microsoft.Azure.IoTCentral;
using Microsoft.Identity.Client;

namespace Examples {
    internal class Program
    {
        public static IPublicClientApplication pca;
        
        private static void Main(string[] args)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            // PCA requires AAD Tenant Id and AAD Client ID, please replace the client id(3dd39459-ca61-4579-b46b-f29dd55fcdb7)
            // And tenant id (35715351-9516-4202-800a-3af7d6d9ecfb).
            pca = PublicClientApplicationBuilder.Create(Constants.ClientApplicationId)
                .WithAuthority($"https://login.microsoftonline.com/{Constants.TenantId}")
                .WithRedirectUri("http://localhost")
                .Build();
            
            // IoT Central Rest API scopes use "https://apps.azureiotcentral.com/.default", do not change the scopes.
            var authResult = pca.AcquireTokenInteractive(Constants.Scopes).ExecuteAsync().GetAwaiter().GetResult();
            // Console.WriteLine(authResult.AccessToken);
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authResult.AccessToken);

            // Replace subdomain "spntest" with your domain.
            using var centralClient = new AzureIoTCentral(httpClient, true);
            centralClient.Subdomain = Constants.AppName;
            centralClient.ApiVersion = Constants.ApiVersion;

            // UserOrgExample.Run(centralClient, options);
            // DeviceTemplateExample.Run(centralClient, options);
            // DeviceExample.Run(centralClient, options);
            // FileUploadExample.Run(centralClient, options);
            // DeviceGroupExample.Run(centralClient, options);
            EnrollmentGroupExample.Run(centralClient, options);
        }
    }
}