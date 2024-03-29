// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class ServiceBusQueueV1DestinationSystemAssignedManagedIdentityAuth : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hostName");
            writer.WriteStringValue(HostName);
            writer.WritePropertyName("queueName");
            writer.WriteStringValue(QueueName);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static ServiceBusQueueV1DestinationSystemAssignedManagedIdentityAuth DeserializeServiceBusQueueV1DestinationSystemAssignedManagedIdentityAuth(JsonElement element)
        {
            string hostName = default;
            string queueName = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostName"))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueName"))
                {
                    queueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceBusQueueV1DestinationSystemAssignedManagedIdentityAuth(type, hostName, queueName);
        }
    }
}
