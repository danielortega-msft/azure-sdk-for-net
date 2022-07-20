// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Defines load balancer frontend IP configuration properties. </summary>
    public partial class LBFrontendIPConfigurationResourceSettings
    {
        /// <summary> Initializes a new instance of LBFrontendIPConfigurationResourceSettings. </summary>
        public LBFrontendIPConfigurationResourceSettings()
        {
        }

        /// <summary> Initializes a new instance of LBFrontendIPConfigurationResourceSettings. </summary>
        /// <param name="name"> Gets or sets the frontend IP configuration name. </param>
        /// <param name="privateIPAddress">
        /// Gets or sets the IP address of the Load Balancer.This is only specified if a specific
        /// private IP address shall be allocated from the subnet specified in subnetRef.
        /// </param>
        /// <param name="privateIPAllocationMethod"> Gets or sets PrivateIP allocation method (Static/Dynamic). </param>
        /// <param name="subnet"> Defines reference to subnet. </param>
        /// <param name="zones"> Gets or sets the csv list of zones. </param>
        internal LBFrontendIPConfigurationResourceSettings(string name, string privateIPAddress, string privateIPAllocationMethod, SubnetReference subnet, string zones)
        {
            Name = name;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            Zones = zones;
        }

        /// <summary> Gets or sets the frontend IP configuration name. </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the IP address of the Load Balancer.This is only specified if a specific
        /// private IP address shall be allocated from the subnet specified in subnetRef.
        /// </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> Gets or sets PrivateIP allocation method (Static/Dynamic). </summary>
        public string PrivateIPAllocationMethod { get; set; }
        /// <summary> Defines reference to subnet. </summary>
        public SubnetReference Subnet { get; set; }
        /// <summary> Gets or sets the csv list of zones. </summary>
        public string Zones { get; set; }
    }
}
