
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.Core.Serialization;

namespace Microsoft.Azure.IoTCentral {
    public class AzureIoTCentralClientOptions : ClientOptions {
        public string SubDomain { get; set; }

        /// <summary>
        /// Used to serialize and deserialize the payloads of user-provided types to/from UTF-8 encoded JSON.
        /// </summary>
        public ObjectSerializer Serializer { get; set; }

        public string BaseDomain { get; set; } = "azureiotcentral.com";
    }
}