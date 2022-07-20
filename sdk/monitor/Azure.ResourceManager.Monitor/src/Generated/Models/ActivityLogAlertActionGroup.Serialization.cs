// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ActivityLogAlertActionGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("actionGroupId");
            writer.WriteStringValue(ActionGroupId);
            if (Optional.IsCollectionDefined(WebhookProperties))
            {
                writer.WritePropertyName("webhookProperties");
                writer.WriteStartObject();
                foreach (var item in WebhookProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ActivityLogAlertActionGroup DeserializeActivityLogAlertActionGroup(JsonElement element)
        {
            ResourceIdentifier actionGroupId = default;
            Optional<IDictionary<string, string>> webhookProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionGroupId"))
                {
                    actionGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("webhookProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    webhookProperties = dictionary;
                    continue;
                }
            }
            return new ActivityLogAlertActionGroup(actionGroupId, Optional.ToDictionary(webhookProperties));
        }
    }
}
