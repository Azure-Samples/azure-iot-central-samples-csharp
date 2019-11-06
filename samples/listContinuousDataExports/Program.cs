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
            httpClient.DefaultRequestHeaders.Add("Authorization", "SharedAccessSignature sr=ba038589-a29b-4466-a730-525657ff0bbe&sig=n6Rf%2BH4VNHpEnbPOqd%2FJMAUCLEKMBcsBqykb4LijOG0%3D&skn=a&se=1604567854722");
            var continuousDataExportsClient = new ContinuousDataExportsClient(httpClient);
            continuousDataExportsClient.BaseUrl = "https://in-store-analytics---condition-monitoring-n167jxnnb5.azureiotcentral.com/api/preview";

            var result = await continuousDataExportsClient.ListAsync();

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
