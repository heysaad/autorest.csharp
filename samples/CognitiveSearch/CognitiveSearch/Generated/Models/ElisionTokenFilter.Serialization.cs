// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class ElisionTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Articles != null)
            {
                writer.WritePropertyName("articles");
                writer.WriteStartArray();
                foreach (var item in Articles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
        internal static ElisionTokenFilter DeserializeElisionTokenFilter(JsonElement element)
        {
            ElisionTokenFilter result = new ElisionTokenFilter();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("articles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Articles = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Articles.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    result.OdataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}