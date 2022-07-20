// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Required for resources collection. </summary>
    public partial class RequiredForResourcesCollection
    {
        /// <summary> Initializes a new instance of RequiredForResourcesCollection. </summary>
        internal RequiredForResourcesCollection()
        {
            SourceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RequiredForResourcesCollection. </summary>
        /// <param name="sourceIds"> Gets or sets the list of source Ids for which the input resource is required. </param>
        internal RequiredForResourcesCollection(IReadOnlyList<string> sourceIds)
        {
            SourceIds = sourceIds;
        }

        /// <summary> Gets or sets the list of source Ids for which the input resource is required. </summary>
        public IReadOnlyList<string> SourceIds { get; }
    }
}
