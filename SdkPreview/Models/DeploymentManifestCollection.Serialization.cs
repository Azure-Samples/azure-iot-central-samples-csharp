// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    internal partial class DeploymentManifestCollection
    {
        internal static DeploymentManifestCollection DeserializeDeploymentManifestCollection(JsonElement element)
        {
            IReadOnlyList<DeploymentManifest> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DeploymentManifest> array = new List<DeploymentManifest>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeploymentManifest.DeserializeDeploymentManifest(item));
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
            return new DeploymentManifestCollection(value, nextLink.Value);
        }
    }
}
