// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> The resource model definition for a Azure Resource Manager proxy resource. It will not have tags and a location. </summary>
    public partial class ProxyResource : Resource
    {
        /// <summary> Initializes a new instance of ProxyResource. </summary>
        public ProxyResource()
        {
        }

        /// <summary> Initializes a new instance of ProxyResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        internal ProxyResource(ResourceIdentifier id, string name, ResourceType type, SystemData systemData) : base(id, name, type, systemData)
        {
        }
    }
}
