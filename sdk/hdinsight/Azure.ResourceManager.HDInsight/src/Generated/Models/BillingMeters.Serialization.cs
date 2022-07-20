// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class BillingMeters
    {
        internal static BillingMeters DeserializeBillingMeters(JsonElement element)
        {
            Optional<string> meterParameter = default;
            Optional<string> meter = default;
            Optional<string> unit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("meterParameter"))
                {
                    meterParameter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meter"))
                {
                    meter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
            }
            return new BillingMeters(meterParameter.Value, meter.Value, unit.Value);
        }
    }
}
