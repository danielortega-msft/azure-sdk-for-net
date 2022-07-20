// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The response of the List Event Hubs Clusters operation. </summary>
    internal partial class ClusterListResult
    {
        /// <summary> Initializes a new instance of ClusterListResult. </summary>
        internal ClusterListResult()
        {
            Value = new ChangeTrackingList<EventHubsClusterData>();
        }

        /// <summary> Initializes a new instance of ClusterListResult. </summary>
        /// <param name="value"> The Event Hubs Clusters present in the List Event Hubs operation results. </param>
        /// <param name="nextLink"> Link to the next set of results. Empty unless the value parameter contains an incomplete list of Event Hubs Clusters. </param>
        internal ClusterListResult(IReadOnlyList<EventHubsClusterData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The Event Hubs Clusters present in the List Event Hubs operation results. </summary>
        public IReadOnlyList<EventHubsClusterData> Value { get; }
        /// <summary> Link to the next set of results. Empty unless the value parameter contains an incomplete list of Event Hubs Clusters. </summary>
        public string NextLink { get; }
    }
}
