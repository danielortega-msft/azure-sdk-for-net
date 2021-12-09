// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Connection state of the private endpoint connection. </summary>
    public partial class PrivateLinkServiceConnectionState
    {
        /// <summary> Initializes a new instance of PrivateLinkServiceConnectionState. </summary>
        public PrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of PrivateLinkServiceConnectionState. </summary>
        /// <param name="status"> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service. </param>
        /// <param name="description"> The reason for approval/rejection of the connection. </param>
        /// <param name="actionsRequired"> A message indicating if changes on the service provider require any updates on the consumer. </param>
        internal PrivateLinkServiceConnectionState(PrivateLinkServiceConnectionStatus? status, string description, string actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service. </summary>
        public PrivateLinkServiceConnectionStatus? Status { get; set; }
        /// <summary> The reason for approval/rejection of the connection. </summary>
        public string Description { get; set; }
        /// <summary> A message indicating if changes on the service provider require any updates on the consumer. </summary>
        public string ActionsRequired { get; set; }
    }
}
