// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class LabelTileConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("text");
            writer.WriteStringValue(Text);
            if (Optional.IsDefined(TextSize))
            {
                writer.WritePropertyName("textSize");
                writer.WriteNumberValue(TextSize.Value);
            }
            if (Optional.IsDefined(TextSizeUnit))
            {
                writer.WritePropertyName("textSizeUnit");
                writer.WriteStringValue(TextSizeUnit.Value.ToString());
            }
            if (Optional.IsDefined(WordWrap))
            {
                writer.WritePropertyName("wordWrap");
                writer.WriteBooleanValue(WordWrap.Value);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static LabelTileConfiguration DeserializeLabelTileConfiguration(JsonElement element)
        {
            string text = default;
            Optional<float> textSize = default;
            Optional<TileTextSizeUnit> textSizeUnit = default;
            Optional<bool> wordWrap = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("textSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    textSize = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("textSizeUnit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    textSizeUnit = new TileTextSizeUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("wordWrap"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    wordWrap = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new LabelTileConfiguration(type, text, Optional.ToNullable(textSize), Optional.ToNullable(textSizeUnit), Optional.ToNullable(wordWrap));
        }
    }
}