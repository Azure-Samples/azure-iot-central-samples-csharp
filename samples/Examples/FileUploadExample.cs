using System.Text.Json;
using Microsoft.Azure.IoTCentral;
using Microsoft.Azure.IoTCentral.Models;

namespace Examples {
    // Config IoT Central Application File Upload Configuration
    public class FileUploadExample {
        public static void Run(AzureIoTCentral centralClient, JsonSerializerOptions options) {
            try {
                var config = centralClient.FileUploads.Get();
            } catch (ErrorException e) {
                if(e.Response.StatusCode == System.Net.HttpStatusCode.NotFound) {
                    Console.WriteLine("\nCurrent File Upload Configuration is not existed, please create one");
                }

                var fileUpload = new FileUpload {
                    ConnectionString = "",
                    Container = "",
                    SasTtl = ""
                };

                var config = centralClient.FileUploads.Create(fileUpload);

                Console.WriteLine("\nFile upload configured for your application successfully!");

                // Remove file upload config.
                centralClient.FileUploads.Remove();
            }
        }
    }
}