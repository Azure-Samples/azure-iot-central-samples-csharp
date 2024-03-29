// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class EnrollmentGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("displayName");
            writer.WriteStringValue(DisplayName);
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToSerialString());
            writer.WritePropertyName("attestation");
            writer.WriteObjectValue(Attestation);
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            writer.WriteEndObject();
        }

        internal static EnrollmentGroup DeserializeEnrollmentGroup(JsonElement element)
        {
            Optional<string> id = default;
            string displayName = default;
            Optional<bool> enabled = default;
            EnrollmentGroupType type = default;
            GroupAttestation attestation = default;
            Optional<string> etag = default;
            Optional<string> idScope = default;
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
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString().ToEnrollmentGroupType();
                    continue;
                }
                if (property.NameEquals("attestation"))
                {
                    attestation = GroupAttestation.DeserializeGroupAttestation(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("idScope"))
                {
                    idScope = property.Value.GetString();
                    continue;
                }
            }
            return new EnrollmentGroup(id.Value, displayName, Optional.ToNullable(enabled), type, attestation, etag.Value, idScope.Value);
        }
    }
}
