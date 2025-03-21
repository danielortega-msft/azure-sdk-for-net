// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class MetricSeriesGroupDetectionCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("group"u8);
            writer.WriteObjectValue<DimensionKey>(SeriesGroupKey);
            if (Optional.IsDefined(ConditionOperator))
            {
                writer.WritePropertyName("conditionOperator"u8);
                writer.WriteStringValue(ConditionOperator.Value.ToString());
            }
            if (Optional.IsDefined(SmartDetectionCondition))
            {
                writer.WritePropertyName("smartDetectionCondition"u8);
                writer.WriteObjectValue<SmartDetectionCondition>(SmartDetectionCondition);
            }
            if (Optional.IsDefined(HardThresholdCondition))
            {
                writer.WritePropertyName("hardThresholdCondition"u8);
                writer.WriteObjectValue<HardThresholdCondition>(HardThresholdCondition);
            }
            if (Optional.IsDefined(ChangeThresholdCondition))
            {
                writer.WritePropertyName("changeThresholdCondition"u8);
                writer.WriteObjectValue<ChangeThresholdCondition>(ChangeThresholdCondition);
            }
            writer.WriteEndObject();
        }

        internal static MetricSeriesGroupDetectionCondition DeserializeMetricSeriesGroupDetectionCondition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DimensionKey group = default;
            DetectionConditionOperator? conditionOperator = default;
            SmartDetectionCondition smartDetectionCondition = default;
            HardThresholdCondition hardThresholdCondition = default;
            ChangeThresholdCondition changeThresholdCondition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("group"u8))
                {
                    group = DimensionKey.DeserializeDimensionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("conditionOperator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conditionOperator = new DetectionConditionOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("smartDetectionCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smartDetectionCondition = Models.SmartDetectionCondition.DeserializeSmartDetectionCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("hardThresholdCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hardThresholdCondition = Models.HardThresholdCondition.DeserializeHardThresholdCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("changeThresholdCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeThresholdCondition = Models.ChangeThresholdCondition.DeserializeChangeThresholdCondition(property.Value);
                    continue;
                }
            }
            return new MetricSeriesGroupDetectionCondition(conditionOperator, smartDetectionCondition, hardThresholdCondition, changeThresholdCondition, group);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new MetricSeriesGroupDetectionCondition FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeMetricSeriesGroupDetectionCondition(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
