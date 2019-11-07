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

            var result = await continuousDataExportsClient.GetAsync("306e7c12-75dd-4797-936e-f2fb5e9f309b");

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
