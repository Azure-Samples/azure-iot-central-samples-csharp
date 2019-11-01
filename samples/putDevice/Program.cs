using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using IoTCentralSDK;

namespace IoTCentral
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "[ACCESS_TOKEN]");
            var deviceClient = new DevicesClient(httpClient);
            deviceClient.BaseUrl = "https://[APP_NAME].azureiotcentral.com/api/preview";

            var deviceId = "deviceId";
            var device = new Device();
            device.Id = deviceId;
            device.Etag = "eyJoZWFkZXIiOiJcIjUxMDEzY2RiLTAwMDAtMGQwMC0wMDAwLTVkYj**************";
            device.DisplayName = "MyDisplayName";
            device.InstanceOf = "urn:iotc:modelDefinition:$unassigned";
            device.Simulated = false;
            var result = await deviceClient.SetAsync(device, deviceId);

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
