// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class DiagnosticAnalysisCollection
    {
        internal static DiagnosticAnalysisCollection DeserializeDiagnosticAnalysisCollection(JsonElement element)
        {
            IReadOnlyList<AnalysisDefinitionData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<AnalysisDefinitionData> array = new List<AnalysisDefinitionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalysisDefinitionData.DeserializeAnalysisDefinitionData(item));
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
            return new DiagnosticAnalysisCollection(value, nextLink.Value);
        }
    }
}
