// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    internal partial class Error
    {
        internal static Error DeserializeError(JsonElement element)
        {
            ErrorDetails error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    error = ErrorDetails.DeserializeErrorDetails(property.Value);
                    continue;
                }
            }
            return new Error(error);
        }
    }
}
