// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class ExportDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Transform))
            {
                writer.WritePropertyName("transform");
                writer.WriteStringValue(Transform);
            }
            writer.WritePropertyName("displayName");
            writer.WriteStringValue(DisplayName);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static ExportDestination DeserializeExportDestination(JsonElement element)
        {
            Optional<string> transform = default;
            Optional<string> id = default;
            string displayName = default;
            string type = default;
            Optional<string> status = default;
            Optional<IReadOnlyList<DataExportError>> errors = default;
            Optional<DateTimeOffset> lastExportTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transform"))
                {
                    transform = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataExportError> array = new List<DataExportError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataExportError.DeserializeDataExportError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("lastExportTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastExportTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ExportDestination(status.Value, Optional.ToList(errors), Optional.ToNullable(lastExportTime), id.Value, displayName, type, transform.Value);
        }
    }
}
