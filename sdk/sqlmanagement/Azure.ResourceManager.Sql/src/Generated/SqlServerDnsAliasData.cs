// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the SqlServerDnsAlias data model. </summary>
    public partial class SqlServerDnsAliasData : ResourceData
    {
        /// <summary> Initializes a new instance of SqlServerDnsAliasData. </summary>
        public SqlServerDnsAliasData()
        {
        }

        /// <summary> Initializes a new instance of SqlServerDnsAliasData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="azureDnsRecord"> The fully qualified DNS record for alias. </param>
        internal SqlServerDnsAliasData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string azureDnsRecord) : base(id, name, resourceType, systemData)
        {
            AzureDnsRecord = azureDnsRecord;
        }

        /// <summary> The fully qualified DNS record for alias. </summary>
        public string AzureDnsRecord { get; }
    }
}
