// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Role eligibility schedule instance list operation result. </summary>
    internal partial class RoleEligibilityScheduleInstanceListResult
    {
        /// <summary> Initializes a new instance of RoleEligibilityScheduleInstanceListResult. </summary>
        internal RoleEligibilityScheduleInstanceListResult()
        {
            Value = new ChangeTrackingList<RoleEligibilityScheduleInstanceData>();
        }

        /// <summary> Initializes a new instance of RoleEligibilityScheduleInstanceListResult. </summary>
        /// <param name="value"> Role eligibility schedule instance list. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal RoleEligibilityScheduleInstanceListResult(IReadOnlyList<RoleEligibilityScheduleInstanceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Role eligibility schedule instance list. </summary>
        public IReadOnlyList<RoleEligibilityScheduleInstanceData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
