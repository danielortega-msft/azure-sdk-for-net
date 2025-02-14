// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsMessageMediaContent
    {
        internal static AcsMessageMediaContent DeserializeAcsMessageMediaContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string mimeType = default;
            string id = default;
            string fileName = default;
            string caption = default;
            bool? animated = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mimeType"u8))
                {
                    mimeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileName"u8))
                {
                    fileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("caption"u8))
                {
                    caption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("animated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    animated = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AcsMessageMediaContent(mimeType, id, fileName, caption, animated);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AcsMessageMediaContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAcsMessageMediaContent(document.RootElement);
        }
    }
}
