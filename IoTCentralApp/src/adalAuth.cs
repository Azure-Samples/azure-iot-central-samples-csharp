using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;
using System.Linq;
using System;


namespace IoTCentralApp
{
    public class IoTCentralAdal
    {
        private const string ClientId = "04b07795-8ddb-461a-bbee-02f9e1bf7b46";

        private string resource = "https://apps.azureiotcentral.com";

        public async Task<AuthenticationResult> GetCodeAsync()
        {
            AuthenticationContext context = new AuthenticationContext("https://login.microsoftonline.com/common", true);
            var deviceCode = await context.AcquireDeviceCodeAsync(resource, ClientId).ConfigureAwait(false);
            Console.ResetColor();
            Console.WriteLine("You need to sign in.");
            Console.WriteLine("Message: " + deviceCode.Message + "\n");
            var result = await context.AcquireTokenByDeviceCodeAsync(deviceCode).ConfigureAwait(false);
            return result;
        }
    }
}