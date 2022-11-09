using Microsoft.Azure.IoTCentral.Preview;
using Azure.Identity;
using System;

namespace PreviewExamples {
    internal class Program
    {        
        private static void Main(string[] args)
        {
            // Using 'az login' first, and using 'az account set -s subscription'
            var credential = new AzureCliCredential();
            var subdomain = "spntest";

            // Users example
            // UserRoleOrgsExample.Run(subdomain, credential);

            DeviceExample.Run(subdomain, credential);
        }
    }
}