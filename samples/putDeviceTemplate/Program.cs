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
            var deviceTemplatesClient = new DeviceTemplatesClient(httpClient);
            deviceTemplatesClient.BaseUrl = "https://[APP_NAME].azureiotcentral.com/api/preview";

            string template;
            using (StreamReader r = new StreamReader(Path.Combine(System.AppContext.BaseDirectory, "template.json")))
            {
                template = r.ReadToEnd();
            }
            
            var a = Newtonsoft.Json.JsonConvert.DeserializeObject<DeviceTemplate>(template);
            
            var result = await deviceTemplatesClient.SetAsync(a, "urn:jlqzoun1k:modelDefinition:kprwlytc22");            

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
