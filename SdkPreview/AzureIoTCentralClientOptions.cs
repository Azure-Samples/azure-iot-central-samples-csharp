// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview
{
    /// <summary> Client options for AzureIoTCentralClient. </summary>
    public partial class AzureIoTCentralClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2022_10_31_Preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2022-10-31-preview". </summary>
            V2022_10_31_Preview = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of AzureIoTCentralClientOptions. </summary>
        public AzureIoTCentralClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2022_10_31_Preview => "2022-10-31-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}
