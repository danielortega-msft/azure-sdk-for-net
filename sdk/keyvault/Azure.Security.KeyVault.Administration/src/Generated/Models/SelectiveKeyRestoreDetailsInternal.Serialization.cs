// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace Azure.Security.KeyVault.Administration.Models
{
    internal partial class SelectiveKeyRestoreDetailsInternal
    {
        internal static SelectiveKeyRestoreDetailsInternal DeserializeSelectiveKeyRestoreDetailsInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OperationStatus? status = default;
            string statusDetails = default;
            KeyVaultServiceError error = default;
            string jobId = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new OperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusDetails"u8))
                {
                    statusDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        error = null;
                        continue;
                    }
                    error = KeyVaultServiceError.DeserializeKeyVaultServiceError(property.Value);
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
            }
            return new SelectiveKeyRestoreDetailsInternal(
                status,
                statusDetails,
                error,
                jobId,
                startTime,
                endTime);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SelectiveKeyRestoreDetailsInternal FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSelectiveKeyRestoreDetailsInternal(document.RootElement);
        }
    }
}
