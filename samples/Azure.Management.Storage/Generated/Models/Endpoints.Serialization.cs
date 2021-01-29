// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class Endpoints
    {
        internal static Endpoints DeserializeEndpoints(JsonElement element)
        {
            Optional<string> blob = default;
            Optional<string> queue = default;
            Optional<string> table = default;
            Optional<string> file = default;
            Optional<string> web = default;
            Optional<string> dfs = default;
            Optional<StorageAccountMicrosoftEndpoints> microsoftEndpoints = default;
            Optional<StorageAccountInternetEndpoints> internetEndpoints = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blob"))
                {
                    blob = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queue"))
                {
                    queue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("table"))
                {
                    table = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("file"))
                {
                    file = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("web"))
                {
                    web = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dfs"))
                {
                    dfs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("microsoftEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    microsoftEndpoints = StorageAccountMicrosoftEndpoints.DeserializeStorageAccountMicrosoftEndpoints(property.Value);
                    continue;
                }
                if (property.NameEquals("internetEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    internetEndpoints = StorageAccountInternetEndpoints.DeserializeStorageAccountInternetEndpoints(property.Value);
                    continue;
                }
            }
            return new Endpoints(blob.Value, queue.Value, table.Value, file.Value, web.Value, dfs.Value, microsoftEndpoints.Value, internetEndpoints.Value);
        }
    }
}