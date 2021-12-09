// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    public partial class HybridConnectionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceBusNamespace))
            {
                writer.WritePropertyName("serviceBusNamespace");
                writer.WriteStringValue(ServiceBusNamespace);
            }
            if (Optional.IsDefined(RelayName))
            {
                writer.WritePropertyName("relayName");
                writer.WriteStringValue(RelayName);
            }
            if (Optional.IsDefined(RelayArmUri))
            {
                writer.WritePropertyName("relayArmUri");
                writer.WriteStringValue(RelayArmUri);
            }
            if (Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname");
                writer.WriteStringValue(Hostname);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(SendKeyName))
            {
                writer.WritePropertyName("sendKeyName");
                writer.WriteStringValue(SendKeyName);
            }
            if (Optional.IsDefined(SendKeyValue))
            {
                writer.WritePropertyName("sendKeyValue");
                writer.WriteStringValue(SendKeyValue);
            }
            if (Optional.IsDefined(ServiceBusSuffix))
            {
                writer.WritePropertyName("serviceBusSuffix");
                writer.WriteStringValue(ServiceBusSuffix);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HybridConnectionData DeserializeHybridConnectionData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> serviceBusNamespace = default;
            Optional<string> relayName = default;
            Optional<string> relayArmUri = default;
            Optional<string> hostname = default;
            Optional<int> port = default;
            Optional<string> sendKeyName = default;
            Optional<string> sendKeyValue = default;
            Optional<string> serviceBusSuffix = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("serviceBusNamespace"))
                        {
                            serviceBusNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("relayName"))
                        {
                            relayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("relayArmUri"))
                        {
                            relayArmUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostname"))
                        {
                            hostname = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sendKeyName"))
                        {
                            sendKeyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sendKeyValue"))
                        {
                            sendKeyValue = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceBusSuffix"))
                        {
                            serviceBusSuffix = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HybridConnectionData(id, name, type, kind.Value, serviceBusNamespace.Value, relayName.Value, relayArmUri.Value, hostname.Value, Optional.ToNullable(port), sendKeyName.Value, sendKeyValue.Value, serviceBusSuffix.Value);
        }
    }
}
