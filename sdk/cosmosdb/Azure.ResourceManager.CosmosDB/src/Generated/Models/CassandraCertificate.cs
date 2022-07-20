// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CassandraCertificate. </summary>
    public partial class CassandraCertificate
    {
        /// <summary> Initializes a new instance of CassandraCertificate. </summary>
        public CassandraCertificate()
        {
        }

        /// <summary> Initializes a new instance of CassandraCertificate. </summary>
        /// <param name="pem"> PEM formatted public key. </param>
        internal CassandraCertificate(string pem)
        {
            Pem = pem;
        }

        /// <summary> PEM formatted public key. </summary>
        public string Pem { get; set; }
    }
}
