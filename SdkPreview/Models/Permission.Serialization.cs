// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class Permission : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("roles");
            writer.WriteStartArray();
            foreach (var item in Roles)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static Permission DeserializePermission(JsonElement element)
        {
            IList<RoleAssignment> roles = default;
            foreach (var property in element.EnumerateObject())
            {
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
            return new Permission(roles);
        }
    }
}
