// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    public partial class ConversationAnalysisOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("conversationItem");
            writer.WriteObjectValue(ConversationItem);
            writer.WriteEndObject();
        }
    }
}
