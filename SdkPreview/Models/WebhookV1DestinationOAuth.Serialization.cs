// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class WebhookV1DestinationOAuth : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tokenUrl");
            writer.WriteStringValue(TokenUrl);
            writer.WritePropertyName("clientId");
            writer.WriteStringValue(ClientId);
            writer.WritePropertyName("clientSecret");
            writer.WriteStringValue(ClientSecret);
            if (Optional.IsDefined(Audience))
            {
                writer.WritePropertyName("audience");
                writer.WriteStringValue(Audience);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(RequestType))
            {
                writer.WritePropertyName("requestType");
                writer.WriteStringValue(RequestType.Value.ToSerialString());
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static WebhookV1DestinationOAuth DeserializeWebhookV1DestinationOAuth(JsonElement element)
        {
            string tokenUrl = default;
            string clientId = default;
            string clientSecret = default;
            Optional<string> audience = default;
            Optional<string> scope = default;
            Optional<OAuthRequestType> requestType = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tokenUrl"))
                {
                    tokenUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecret"))
                {
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("audience"))
                {
                    audience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestType = property.Value.GetString().ToOAuthRequestType();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new WebhookV1DestinationOAuth(type, tokenUrl, clientId, clientSecret, audience.Value, scope.Value, Optional.ToNullable(requestType));
        }
    }
}
