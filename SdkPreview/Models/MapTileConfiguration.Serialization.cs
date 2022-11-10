// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class MapTileConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ZoomLevel))
            {
                writer.WritePropertyName("zoomLevel");
                writer.WriteNumberValue(ZoomLevel.Value);
            }
            if (Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities");
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("group");
            writer.WriteStringValue(Group);
            writer.WritePropertyName("devices");
            writer.WriteStartArray();
            foreach (var item in Devices)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static MapTileConfiguration DeserializeMapTileConfiguration(JsonElement element)
        {
            Optional<float> zoomLevel = default;
            Optional<IList<TileCapability>> capabilities = default;
            string group = default;
            IList<string> devices = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zoomLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    zoomLevel = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("capabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TileCapability> array = new List<TileCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TileCapability.DeserializeTileCapability(item));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("group"))
                {
                    group = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("devices"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    devices = array;
                    continue;
                }
            }
            return new MapTileConfiguration(group, devices, Optional.ToNullable(zoomLevel), Optional.ToList(capabilities));
        }
    }
}
