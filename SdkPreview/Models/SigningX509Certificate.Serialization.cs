// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class SigningX509Certificate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Verified))
            {
                writer.WritePropertyName("verified");
                writer.WriteBooleanValue(Verified.Value);
            }
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate");
                writer.WriteStringValue(Certificate);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            writer.WriteEndObject();
        }

        internal static SigningX509Certificate DeserializeSigningX509Certificate(JsonElement element)
        {
            Optional<bool> verified = default;
            Optional<string> certificate = default;
            Optional<X509CertificateInfo> info = default;
            Optional<string> etag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    verified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("certificate"))
                {
                    certificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("info"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    info = X509CertificateInfo.DeserializeX509CertificateInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
            }
            return new SigningX509Certificate(Optional.ToNullable(verified), certificate.Value, info.Value, etag.Value);
        }
    }
}
