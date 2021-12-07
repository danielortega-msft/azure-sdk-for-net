// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class EventHandler : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("urlTemplate");
            writer.WriteStringValue(UrlTemplate);
            if (Optional.IsDefined(UserEventPattern))
            {
                writer.WritePropertyName("userEventPattern");
                writer.WriteStringValue(UserEventPattern);
            }
            if (Optional.IsCollectionDefined(SystemEvents))
            {
                writer.WritePropertyName("systemEvents");
                writer.WriteStartArray();
                foreach (var item in SystemEvents)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Auth))
            {
                writer.WritePropertyName("auth");
                writer.WriteObjectValue(Auth);
            }
            writer.WriteEndObject();
        }

        internal static EventHandler DeserializeEventHandler(JsonElement element)
        {
            string urlTemplate = default;
            Optional<string> userEventPattern = default;
            Optional<IList<string>> systemEvents = default;
            Optional<UpstreamAuthSettings> auth = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("urlTemplate"))
                {
                    urlTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userEventPattern"))
                {
                    userEventPattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemEvents"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    systemEvents = array;
                    continue;
                }
                if (property.NameEquals("auth"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    auth = UpstreamAuthSettings.DeserializeUpstreamAuthSettings(property.Value);
                    continue;
                }
            }
            return new EventHandler(urlTemplate, userEventPattern.Value, Optional.ToList(systemEvents), auth.Value);
        }
    }
}
