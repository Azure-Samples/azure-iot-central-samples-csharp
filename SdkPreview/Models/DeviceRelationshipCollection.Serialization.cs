// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    internal partial class DeviceRelationshipCollection
    {
        internal static DeviceRelationshipCollection DeserializeDeviceRelationshipCollection(JsonElement element)
        {
            IReadOnlyList<DeviceRelationship> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DeviceRelationship> array = new List<DeviceRelationship>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceRelationship.DeserializeDeviceRelationship(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DeviceRelationshipCollection(value, nextLink.Value);
        }
    }
}
