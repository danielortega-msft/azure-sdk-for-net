// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> High availability properties of a server. </summary>
    public partial class HighAvailability
    {
        /// <summary> Initializes a new instance of HighAvailability. </summary>
        public HighAvailability()
        {
        }

        /// <summary> Initializes a new instance of HighAvailability. </summary>
        /// <param name="mode"> The HA mode for the server. </param>
        /// <param name="state"> A state of a HA server that is visible to user. </param>
        /// <param name="standbyAvailabilityZone"> availability zone information of the standby. </param>
        internal HighAvailability(HighAvailabilityMode? mode, ServerHAState? state, string standbyAvailabilityZone)
        {
            Mode = mode;
            State = state;
            StandbyAvailabilityZone = standbyAvailabilityZone;
        }

        /// <summary> The HA mode for the server. </summary>
        public HighAvailabilityMode? Mode { get; set; }
        /// <summary> A state of a HA server that is visible to user. </summary>
        public ServerHAState? State { get; }
        /// <summary> availability zone information of the standby. </summary>
        public string StandbyAvailabilityZone { get; set; }
    }
}
