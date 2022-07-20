// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Additional SQL Server feature settings. </summary>
    internal partial class AdditionalFeaturesServerConfigurations
    {
        /// <summary> Initializes a new instance of AdditionalFeaturesServerConfigurations. </summary>
        public AdditionalFeaturesServerConfigurations()
        {
        }

        /// <summary> Initializes a new instance of AdditionalFeaturesServerConfigurations. </summary>
        /// <param name="isRServicesEnabled"> Enable or disable R services (SQL 2016 onwards). </param>
        internal AdditionalFeaturesServerConfigurations(bool? isRServicesEnabled)
        {
            IsRServicesEnabled = isRServicesEnabled;
        }

        /// <summary> Enable or disable R services (SQL 2016 onwards). </summary>
        public bool? IsRServicesEnabled { get; set; }
    }
}
