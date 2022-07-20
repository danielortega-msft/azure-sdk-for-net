// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> IP Rule to be applied as part of Network Rule Set. </summary>
    public partial class IotHubNetworkRuleSetIPRule
    {
        /// <summary> Initializes a new instance of IotHubNetworkRuleSetIPRule. </summary>
        /// <param name="filterName"> Name of the IP filter rule. </param>
        /// <param name="ipMask"> A string that contains the IP address range in CIDR notation for the rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filterName"/> or <paramref name="ipMask"/> is null. </exception>
        public IotHubNetworkRuleSetIPRule(string filterName, string ipMask)
        {
            if (filterName == null)
            {
                throw new ArgumentNullException(nameof(filterName));
            }
            if (ipMask == null)
            {
                throw new ArgumentNullException(nameof(ipMask));
            }

            FilterName = filterName;
            IPMask = ipMask;
        }

        /// <summary> Initializes a new instance of IotHubNetworkRuleSetIPRule. </summary>
        /// <param name="filterName"> Name of the IP filter rule. </param>
        /// <param name="action"> IP Filter Action. </param>
        /// <param name="ipMask"> A string that contains the IP address range in CIDR notation for the rule. </param>
        internal IotHubNetworkRuleSetIPRule(string filterName, IotHubNetworkRuleIPAction? action, string ipMask)
        {
            FilterName = filterName;
            Action = action;
            IPMask = ipMask;
        }

        /// <summary> Name of the IP filter rule. </summary>
        public string FilterName { get; set; }
        /// <summary> IP Filter Action. </summary>
        public IotHubNetworkRuleIPAction? Action { get; set; }
        /// <summary> A string that contains the IP address range in CIDR notation for the rule. </summary>
        public string IPMask { get; set; }
    }
}
