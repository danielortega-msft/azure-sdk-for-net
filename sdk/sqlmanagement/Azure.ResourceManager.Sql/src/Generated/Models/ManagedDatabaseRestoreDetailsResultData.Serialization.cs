// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedDatabaseRestoreDetailsResultData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagedDatabaseRestoreDetailsResultData DeserializeManagedDatabaseRestoreDetailsResultData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> status = default;
            Optional<string> currentRestoringFileName = default;
            Optional<string> lastRestoredFileName = default;
            Optional<DateTimeOffset> lastRestoredFileTime = default;
            Optional<double> percentCompleted = default;
            Optional<IReadOnlyList<string>> unrestorableFiles = default;
            Optional<long> numberOfFilesDetected = default;
            Optional<string> lastUploadedFileName = default;
            Optional<DateTimeOffset> lastUploadedFileTime = default;
            Optional<string> blockReason = default;
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("status"))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentRestoringFileName"))
                        {
                            currentRestoringFileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastRestoredFileName"))
                        {
                            lastRestoredFileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastRestoredFileTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastRestoredFileTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("percentCompleted"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            percentCompleted = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("unrestorableFiles"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            unrestorableFiles = array;
                            continue;
                        }
                        if (property0.NameEquals("numberOfFilesDetected"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            numberOfFilesDetected = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("lastUploadedFileName"))
                        {
                            lastUploadedFileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastUploadedFileTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastUploadedFileTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("blockReason"))
                        {
                            blockReason = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedDatabaseRestoreDetailsResultData(id, name, type, status.Value, currentRestoringFileName.Value, lastRestoredFileName.Value, Optional.ToNullable(lastRestoredFileTime), Optional.ToNullable(percentCompleted), Optional.ToList(unrestorableFiles), Optional.ToNullable(numberOfFilesDetected), lastUploadedFileName.Value, Optional.ToNullable(lastUploadedFileTime), blockReason.Value);
        }
    }
}
