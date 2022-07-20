// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Type of the key source. </summary>
    public enum KeySource
    {
        /// <summary> Batch creates and manages the encryption keys used to protect the account data. </summary>
        MicrosoftBatch,
        /// <summary> The encryption keys used to protect the account data are stored in an external key vault. If this is set then the Batch Account identity must be set to `SystemAssigned` and a valid Key Identifier must also be supplied under the keyVaultProperties. </summary>
        MicrosoftKeyVault
    }
}
