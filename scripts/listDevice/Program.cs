using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace listDevice
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static async Task ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Authorization", "[ACCESS_TOKEN]");
            var stringTask = client.GetStringAsync("https://[APP_NAME].azureiotcentral.com/api/preview/devices");

            var msg = await stringTask;
            Console.Write(msg);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("API Call Start");
            ProcessRepositories().Wait();
            Console.WriteLine("API Call End");
        }
    }
}
