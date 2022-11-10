// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class BlobStorageV1DestinationConnectionStringAuth : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("connectionString");
            writer.WriteStringValue(ConnectionString);
            writer.WritePropertyName("containerName");
            writer.WriteStringValue(ContainerName);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static BlobStorageV1DestinationConnectionStringAuth DeserializeBlobStorageV1DestinationConnectionStringAuth(JsonElement element)
        {
            string connectionString = default;
            string containerName = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionString"))
                {
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new BlobStorageV1DestinationConnectionStringAuth(type, connectionString, containerName);
        }
    }
}
