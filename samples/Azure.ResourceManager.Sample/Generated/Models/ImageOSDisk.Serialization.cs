// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class ImageOSDisk : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("osType");
            writer.WriteStringValue(OsType.ToSerialString());
            writer.WritePropertyName("osState");
            writer.WriteStringValue(OsState.ToSerialString());
            if (Optional.IsDefined(Snapshot))
            {
                writer.WritePropertyName("snapshot");
                JsonSerializer.Serialize(writer, Snapshot);
            }
            if (Optional.IsDefined(ManagedDisk))
            {
                writer.WritePropertyName("managedDisk");
                JsonSerializer.Serialize(writer, ManagedDisk);
            }
            if (Optional.IsDefined(BlobUri))
            {
                writer.WritePropertyName("blobUri");
                writer.WriteStringValue(BlobUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Caching))
            {
                writer.WritePropertyName("caching");
                writer.WriteStringValue(Caching.Value.ToSerialString());
            }
            if (Optional.IsDefined(DiskSizeGB))
            {
                writer.WritePropertyName("diskSizeGB");
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType");
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            if (Optional.IsDefined(DiskEncryptionSet))
            {
                writer.WritePropertyName("diskEncryptionSet");
                JsonSerializer.Serialize(writer, DiskEncryptionSet);
            }
            writer.WriteEndObject();
        }

        internal static ImageOSDisk DeserializeImageOSDisk(JsonElement element)
        {
            OperatingSystemTypes osType = default;
            OperatingSystemStateTypes osState = default;
            Optional<WritableSubResource> snapshot = default;
            Optional<WritableSubResource> managedDisk = default;
            Optional<Uri> blobUri = default;
            Optional<CachingTypes> caching = default;
            Optional<int> diskSizeGB = default;
            Optional<StorageAccountTypes> storageAccountType = default;
            Optional<WritableSubResource> diskEncryptionSet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"))
                {
                    osType = property.Value.GetString().ToOperatingSystemTypes();
                    continue;
                }
                if (property.NameEquals("osState"))
                {
                    osState = property.Value.GetString().ToOperatingSystemStateTypes();
                    continue;
                }
                if (property.NameEquals("snapshot"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    snapshot = JsonSerializer.Deserialize<WritableSubResource>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("managedDisk"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    managedDisk = JsonSerializer.Deserialize<WritableSubResource>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("blobUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        blobUri = null;
                        continue;
                    }
                    blobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("caching"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    caching = property.Value.GetString().ToCachingTypes();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAccountType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageAccountType = new StorageAccountTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskEncryptionSet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskEncryptionSet = JsonSerializer.Deserialize<WritableSubResource>(property.Value.ToString());
                    continue;
                }
            }
            return new ImageOSDisk(snapshot, managedDisk, blobUri.Value, Optional.ToNullable(caching), Optional.ToNullable(diskSizeGB), Optional.ToNullable(storageAccountType), diskEncryptionSet, osType, osState);
        }
    }
}
