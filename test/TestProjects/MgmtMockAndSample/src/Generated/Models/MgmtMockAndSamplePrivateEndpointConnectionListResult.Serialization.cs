// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using MgmtMockAndSample;

namespace MgmtMockAndSample.Models
{
    internal partial class MgmtMockAndSamplePrivateEndpointConnectionListResult
    {
        internal static MgmtMockAndSamplePrivateEndpointConnectionListResult DeserializeMgmtMockAndSamplePrivateEndpointConnectionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MgmtMockAndSamplePrivateEndpointConnectionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MgmtMockAndSamplePrivateEndpointConnectionData> array = new List<MgmtMockAndSamplePrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MgmtMockAndSamplePrivateEndpointConnectionData.DeserializeMgmtMockAndSamplePrivateEndpointConnectionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MgmtMockAndSamplePrivateEndpointConnectionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
