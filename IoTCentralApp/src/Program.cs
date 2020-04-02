using System;
using System.Threading.Tasks;

namespace IoTCentralApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting Azure IoT Central Application...");
            var console = new IoTCentralConsole();
            await console.RunAsync();
        }
    }
}
