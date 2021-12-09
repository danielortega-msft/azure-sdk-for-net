// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The FrontEndConfiguration. </summary>
    public partial class FrontEndConfiguration
    {
        /// <summary> Initializes a new instance of FrontEndConfiguration. </summary>
        public FrontEndConfiguration()
        {
        }

        /// <summary> Initializes a new instance of FrontEndConfiguration. </summary>
        /// <param name="kind"></param>
        internal FrontEndConfiguration(FrontEndServiceType? kind)
        {
            Kind = kind;
        }

        /// <summary> Gets or sets the kind. </summary>
        public FrontEndServiceType? Kind { get; set; }
    }
}
