// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Management.Storage.Models;
using Azure.ResourceManager.Models;

namespace Azure.Management.Storage
{
    public partial class ObjectReplicationPolicyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceAccount))
            {
                writer.WritePropertyName("sourceAccount");
                writer.WriteStringValue(SourceAccount);
            }
            if (Optional.IsDefined(DestinationAccount))
            {
                writer.WritePropertyName("destinationAccount");
                writer.WriteStringValue(DestinationAccount);
            }
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules");
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ObjectReplicationPolicyData DeserializeObjectReplicationPolicyData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            ResourceManager.Models.SystemData systemData = default;
            Optional<string> policyId = default;
            Optional<DateTimeOffset> enabledTime = default;
            Optional<string> sourceAccount = default;
            Optional<string> destinationAccount = default;
            Optional<IList<ObjectReplicationPolicyRule>> rules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<ResourceManager.Models.SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("policyId"))
                        {
                            policyId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabledTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabledTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sourceAccount"))
                        {
                            sourceAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("destinationAccount"))
                        {
                            destinationAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("rules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ObjectReplicationPolicyRule> array = new List<ObjectReplicationPolicyRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ObjectReplicationPolicyRule.DeserializeObjectReplicationPolicyRule(item));
                            }
                            rules = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ObjectReplicationPolicyData(id, name, type, systemData, policyId.Value, Optional.ToNullable(enabledTime), sourceAccount.Value, destinationAccount.Value, Optional.ToList(rules));
        }
    }
}
