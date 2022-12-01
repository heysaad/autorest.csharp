// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace CustomizationsInCadl.Models
{
    public partial class ModelWithCustomizedProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("propertyToMakeInternal");
            writer.WriteNumberValue(PropertyToMakeInternal);
            writer.WritePropertyName("propertyToRename");
            writer.WriteNumberValue(RenamedProperty);
            writer.WritePropertyName("propertyToMakeFloat");
            writer.WriteNumberValue(PropertyToMakeFloat);
            writer.WritePropertyName("propertyToMakeInt");
            writer.WriteNumberValue(PropertyToMakeInt);
            writer.WritePropertyName("propertyToMakeDuration");
            writer.WriteStringValue(PropertyToMakeDuration, "P");
            writer.WritePropertyName("propertyToMakeString");
            writer.WriteStringValue(PropertyToMakeString);
            writer.WritePropertyName("propertyToMakeJsonElement");
            PropertyToMakeJsonElement.WriteTo(writer);
            writer.WritePropertyName("propertyToField");
            writer.WriteStringValue(_propertyToField);
            writer.WriteEndObject();
        }

        internal static ModelWithCustomizedProperties DeserializeModelWithCustomizedProperties(JsonElement element)
        {
            int propertyToMakeInternal = default;
            int propertyToRename = default;
            float propertyToMakeFloat = default;
            int propertyToMakeInt = default;
            TimeSpan propertyToMakeDuration = default;
            string propertyToMakeString = default;
            JsonElement propertyToMakeJsonElement = default;
            string propertyToField = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("propertyToMakeInternal"))
                {
                    propertyToMakeInternal = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("propertyToRename"))
                {
                    propertyToRename = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("propertyToMakeFloat"))
                {
                    propertyToMakeFloat = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("propertyToMakeInt"))
                {
                    propertyToMakeInt = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("propertyToMakeDuration"))
                {
                    propertyToMakeDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("propertyToMakeString"))
                {
                    propertyToMakeString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("propertyToMakeJsonElement"))
                {
                    propertyToMakeJsonElement = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("propertyToField"))
                {
                    propertyToField = property.Value.GetString();
                    continue;
                }
            }
            return new ModelWithCustomizedProperties(propertyToMakeInternal, propertyToRename, propertyToMakeFloat, propertyToMakeInt, propertyToMakeDuration, propertyToMakeString, propertyToMakeJsonElement, propertyToField);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ModelWithCustomizedProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeModelWithCustomizedProperties(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}