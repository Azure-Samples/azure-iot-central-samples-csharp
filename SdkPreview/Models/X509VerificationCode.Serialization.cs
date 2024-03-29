// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class X509VerificationCode
    {
        internal static X509VerificationCode DeserializeX509VerificationCode(JsonElement element)
        {
            Optional<string> verificationCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verificationCode"))
                {
                    verificationCode = property.Value.GetString();
                    continue;
                }
            }
            return new X509VerificationCode(verificationCode.Value);
        }
    }
}
