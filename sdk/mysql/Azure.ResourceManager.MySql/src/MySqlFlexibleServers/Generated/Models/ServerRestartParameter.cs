// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Server restart parameters. </summary>
    public partial class ServerRestartParameter
    {
        /// <summary> Initializes a new instance of ServerRestartParameter. </summary>
        public ServerRestartParameter()
        {
        }

        /// <summary> Whether or not failover to standby server when restarting a server with high availability enabled. </summary>
        public EnableStatusEnum? RestartWithFailover { get; set; }
        /// <summary> The maximum allowed failover time in seconds. </summary>
        public int? MaxFailoverSeconds { get; set; }
    }
}
