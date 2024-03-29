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
    public partial class ApiToken : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Expiry))
            {
                writer.WritePropertyName("expiry");
                writer.WriteStringValue(Expiry.Value, "O");
            }
            writer.WritePropertyName("roles");
            writer.WriteStartArray();
            foreach (var item in Roles)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ApiToken DeserializeApiToken(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> token = default;
            Optional<DateTimeOffset> expiry = default;
            IList<RoleAssignment> roles = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("token"))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiry"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expiry = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("roles"))
                {
                    List<RoleAssignment> array = new List<RoleAssignment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoleAssignment.DeserializeRoleAssignment(item));
                    }
                    roles = array;
                    continue;
                }
            }
            return new ApiToken(roles, id.Value, token.Value, Optional.ToNullable(expiry));
        }
    }
}
