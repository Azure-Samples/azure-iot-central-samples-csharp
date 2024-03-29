// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class X509CertificateInfo
    {
        internal static X509CertificateInfo DeserializeX509CertificateInfo(JsonElement element)
        {
            string sha1Thumbprint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sha1Thumbprint"))
                {
                    sha1Thumbprint = property.Value.GetString();
                    continue;
                }
            }
            return new X509CertificateInfo(sha1Thumbprint);
        }
    }
}
