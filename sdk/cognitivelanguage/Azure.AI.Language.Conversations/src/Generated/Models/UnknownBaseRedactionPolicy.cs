// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Unknown version of BaseRedactionPolicy. </summary>
    internal partial class UnknownBaseRedactionPolicy : BaseRedactionPolicy
    {
        /// <summary> Initializes a new instance of <see cref="UnknownBaseRedactionPolicy"/>. </summary>
        /// <param name="policyKind"> The entity RedactionPolicy object kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownBaseRedactionPolicy(RedactionPolicyKind policyKind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(policyKind, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownBaseRedactionPolicy"/> for deserialization. </summary>
        internal UnknownBaseRedactionPolicy()
        {
        }
    }
}
