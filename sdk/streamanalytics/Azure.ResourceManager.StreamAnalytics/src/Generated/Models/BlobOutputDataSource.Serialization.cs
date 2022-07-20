// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class BlobOutputDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(OutputDataSourceType);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StorageAccounts))
            {
                writer.WritePropertyName("storageAccounts");
                writer.WriteStartArray();
                foreach (var item in StorageAccounts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Container))
            {
                writer.WritePropertyName("container");
                writer.WriteStringValue(Container);
            }
            if (Optional.IsDefined(PathPattern))
            {
                writer.WritePropertyName("pathPattern");
                writer.WriteStringValue(PathPattern);
            }
            if (Optional.IsDefined(DateFormat))
            {
                writer.WritePropertyName("dateFormat");
                writer.WriteStringValue(DateFormat);
            }
            if (Optional.IsDefined(TimeFormat))
            {
                writer.WritePropertyName("timeFormat");
                writer.WriteStringValue(TimeFormat);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode");
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            if (Optional.IsDefined(BlobPathPrefix))
            {
                writer.WritePropertyName("blobPathPrefix");
                writer.WriteStringValue(BlobPathPrefix);
            }
            if (Optional.IsDefined(BlobWriteMode))
            {
                writer.WritePropertyName("blobWriteMode");
                writer.WriteStringValue(BlobWriteMode.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BlobOutputDataSource DeserializeBlobOutputDataSource(JsonElement element)
        {
            string type = default;
            Optional<IList<StorageAccount>> storageAccounts = default;
            Optional<string> container = default;
            Optional<string> pathPattern = default;
            Optional<string> dateFormat = default;
            Optional<string> timeFormat = default;
            Optional<AuthenticationMode> authenticationMode = default;
            Optional<string> blobPathPrefix = default;
            Optional<BlobWriteMode> blobWriteMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("storageAccounts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<StorageAccount> array = new List<StorageAccount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StorageAccount.DeserializeStorageAccount(item));
                            }
                            storageAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("container"))
                        {
                            container = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pathPattern"))
                        {
                            pathPattern = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dateFormat"))
                        {
                            dateFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeFormat"))
                        {
                            timeFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            authenticationMode = new AuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("blobPathPrefix"))
                        {
                            blobPathPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("blobWriteMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            blobWriteMode = new BlobWriteMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BlobOutputDataSource(type, Optional.ToList(storageAccounts), container.Value, pathPattern.Value, dateFormat.Value, timeFormat.Value, Optional.ToNullable(authenticationMode), blobPathPrefix.Value, Optional.ToNullable(blobWriteMode));
        }
    }
}
