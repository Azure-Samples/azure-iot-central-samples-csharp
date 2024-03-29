// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class Organization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Parent))
            {
                writer.WritePropertyName("parent");
                writer.WriteStringValue(Parent);
            }
            writer.WriteEndObject();
        }

        internal static Organization DeserializeOrganization(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> displayName = default;
            Optional<string> parent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parent"))
                {
                    parent = property.Value.GetString();
                    continue;
                }
            }
            return new Organization(id.Value, displayName.Value, parent.Value);
        }
    }
}
