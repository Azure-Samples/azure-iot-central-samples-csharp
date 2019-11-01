using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using IoTCentral;

namespace IoTC
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "[ACCESS_TOKEN]");
            var deviceClient = new DevicesClient(httpClient);
            deviceClient.BaseUrl = "https://[APP_NAME].azureiotcentral.com/api/preview";

            var result = await deviceClient.ListAsync();

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
