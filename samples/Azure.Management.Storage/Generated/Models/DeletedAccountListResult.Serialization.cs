// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Management.Storage;

namespace Azure.Management.Storage.Models
{
    internal partial class DeletedAccountListResult
    {
        internal static DeletedAccountListResult DeserializeDeletedAccountListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DeletedAccountData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DeletedAccountData> array = new List<DeletedAccountData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeletedAccountData.DeserializeDeletedAccountData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DeletedAccountListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}