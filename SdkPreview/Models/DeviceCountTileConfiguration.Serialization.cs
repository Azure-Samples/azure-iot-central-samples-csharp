// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class DeviceCountTileConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Group))
            {
                writer.WritePropertyName("group");
                writer.WriteStringValue(Group);
            }
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format");
                writer.WriteObjectValue(Format);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static DeviceCountTileConfiguration DeserializeDeviceCountTileConfiguration(JsonElement element)
        {
            Optional<string> group = default;
            Optional<TextFormatConfiguration> format = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("group"))
                {
                    group = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("format"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    format = TextFormatConfiguration.DeserializeTextFormatConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new DeviceCountTileConfiguration(type, group.Value, format.Value);
        }
    }
}
