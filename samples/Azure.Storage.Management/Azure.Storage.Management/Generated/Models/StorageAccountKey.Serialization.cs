// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class StorageAccountKey
    {
        internal static StorageAccountKey DeserializeStorageAccountKey(JsonElement element)
        {
            StorageAccountKey result = new StorageAccountKey();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.KeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("permissions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Permissions = property.Value.GetString().ToKeyPermission();
                    continue;
                }
            }
            return result;
        }
    }
}