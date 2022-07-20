// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AlertsManagement;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    internal partial class AlertProcessingRulesList
    {
        internal static AlertProcessingRulesList DeserializeAlertProcessingRulesList(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<AlertProcessingRuleData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AlertProcessingRuleData> array = new List<AlertProcessingRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AlertProcessingRuleData.DeserializeAlertProcessingRuleData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AlertProcessingRulesList(nextLink.Value, Optional.ToList(value));
        }
    }
}
