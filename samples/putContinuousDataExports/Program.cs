using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using IoTCentral;
using System.IO;

namespace IoTC
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "[ACCESS_TOKEN]");
            var continuousDataExportsClient = new ContinuousDataExportsClient(httpClient);
            continuousDataExportsClient.BaseUrl = "https://[APP_NAME].azureiotcentral.com/api/preview";

            var id = "306e7c12-75dd-4797-936e-f2fb5e9f309b";
            var continuousDataExport = new ContinuousDataExport
            {
                Id = id,
                Etag = "3878d48a-2922-49fb-b213-dcd328e5dd2e",
                DisplayName = "Export to Event Hubs 2333",
                Endpoint = new Endpoint
                {
                    Name = "event-hub-1",
                    ConnectionString = "Endpoint=sb://aaaaa.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=*****"
                },
                Status = "running",
                Enabled = false,
                Sources = new System.Collections.ObjectModel.Collection<Sources>() { Sources.Devices, Sources.DeviceTemplates }
            };
            var result = await continuousDataExportsClient.SetAsync(continuousDataExport, id);

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
