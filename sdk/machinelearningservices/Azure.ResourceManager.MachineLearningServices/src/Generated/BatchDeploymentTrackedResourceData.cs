// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing the BatchDeploymentTrackedResource data model. </summary>
    public partial class BatchDeploymentTrackedResourceData : TrackedResource
    {
        /// <summary> Initializes a new instance of BatchDeploymentTrackedResourceData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public BatchDeploymentTrackedResourceData(Location location, BatchDeployment properties) : base(location)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of BatchDeploymentTrackedResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Service identity associated with a resource. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="systemData"> System data associated with resource provider. </param>
        internal BatchDeploymentTrackedResourceData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, Models.ResourceIdentity identity, string kind, BatchDeployment properties, SystemData systemData) : base(id, name, type, tags, location)
        {
            Identity = identity;
            Kind = kind;
            Properties = properties;
            SystemData = systemData;
        }

        /// <summary> Service identity associated with a resource. </summary>
        public Models.ResourceIdentity Identity { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type. </summary>
        public string Kind { get; set; }
        /// <summary> Additional attributes of the entity. </summary>
        public BatchDeployment Properties { get; set; }
        /// <summary> System data associated with resource provider. </summary>
        public SystemData SystemData { get; }
    }
}
