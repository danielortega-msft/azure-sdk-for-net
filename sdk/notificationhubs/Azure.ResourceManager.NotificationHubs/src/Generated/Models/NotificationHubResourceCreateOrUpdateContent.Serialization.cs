// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubResourceCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(NamePropertiesName))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(NamePropertiesName);
            }
            if (Optional.IsDefined(RegistrationTtl))
            {
                writer.WritePropertyName("registrationTtl");
                writer.WriteStringValue(RegistrationTtl);
            }
            if (Optional.IsCollectionDefined(AuthorizationRules))
            {
                writer.WritePropertyName("authorizationRules");
                writer.WriteStartArray();
                foreach (var item in AuthorizationRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ApnsCredential))
            {
                writer.WritePropertyName("apnsCredential");
                writer.WriteObjectValue(ApnsCredential);
            }
            if (Optional.IsDefined(WnsCredential))
            {
                writer.WritePropertyName("wnsCredential");
                writer.WriteObjectValue(WnsCredential);
            }
            if (Optional.IsDefined(GcmCredential))
            {
                writer.WritePropertyName("gcmCredential");
                writer.WriteObjectValue(GcmCredential);
            }
            if (Optional.IsDefined(MpnsCredential))
            {
                writer.WritePropertyName("mpnsCredential");
                writer.WriteObjectValue(MpnsCredential);
            }
            if (Optional.IsDefined(AdmCredential))
            {
                writer.WritePropertyName("admCredential");
                writer.WriteObjectValue(AdmCredential);
            }
            if (Optional.IsDefined(BaiduCredential))
            {
                writer.WritePropertyName("baiduCredential");
                writer.WriteObjectValue(BaiduCredential);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NotificationHubResourceCreateOrUpdateContent DeserializeNotificationHubResourceCreateOrUpdateContent(JsonElement element)
        {
            Optional<NotificationHubsSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> name0 = default;
            Optional<string> registrationTtl = default;
            Optional<IList<SharedAccessAuthorizationRuleProperties>> authorizationRules = default;
            Optional<ApnsCredential> apnsCredential = default;
            Optional<WnsCredential> wnsCredential = default;
            Optional<GcmCredential> gcmCredential = default;
            Optional<MpnsCredential> mpnsCredential = default;
            Optional<AdmCredential> admCredential = default;
            Optional<BaiduCredential> baiduCredential = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = NotificationHubsSku.DeserializeNotificationHubsSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("name"))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("registrationTtl"))
                        {
                            registrationTtl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authorizationRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SharedAccessAuthorizationRuleProperties> array = new List<SharedAccessAuthorizationRuleProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SharedAccessAuthorizationRuleProperties.DeserializeSharedAccessAuthorizationRuleProperties(item));
                            }
                            authorizationRules = array;
                            continue;
                        }
                        if (property0.NameEquals("apnsCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            apnsCredential = ApnsCredential.DeserializeApnsCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("wnsCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            wnsCredential = WnsCredential.DeserializeWnsCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("gcmCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            gcmCredential = GcmCredential.DeserializeGcmCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("mpnsCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            mpnsCredential = MpnsCredential.DeserializeMpnsCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("admCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            admCredential = AdmCredential.DeserializeAdmCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("baiduCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            baiduCredential = BaiduCredential.DeserializeBaiduCredential(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NotificationHubResourceCreateOrUpdateContent(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, name0.Value, registrationTtl.Value, Optional.ToList(authorizationRules), apnsCredential.Value, wnsCredential.Value, gcmCredential.Value, mpnsCredential.Value, admCredential.Value, baiduCredential.Value, sku.Value);
        }
    }
}
