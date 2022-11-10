// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class TimeQueryRangeConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("duration");
            writer.WriteStringValue(Duration.ToString());
            if (Optional.IsDefined(Resolution))
            {
                writer.WritePropertyName("resolution");
                writer.WriteStringValue(Resolution.Value.ToString());
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static TimeQueryRangeConfiguration DeserializeTimeQueryRangeConfiguration(JsonElement element)
        {
            TileTimeRangeDuration duration = default;
            Optional<TileTimeRangeResolution> resolution = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("duration"))
                {
                    duration = new TileTimeRangeDuration(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resolution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resolution = new TileTimeRangeResolution(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new TimeQueryRangeConfiguration(type, duration, Optional.ToNullable(resolution));
        }
    }
}
