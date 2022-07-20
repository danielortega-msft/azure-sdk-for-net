// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Configure your SQL virtual machine to be able to connect to the Azure Key Vault service. </summary>
    public partial class KeyVaultCredentialSettings
    {
        /// <summary> Initializes a new instance of KeyVaultCredentialSettings. </summary>
        public KeyVaultCredentialSettings()
        {
        }

        /// <summary> Initializes a new instance of KeyVaultCredentialSettings. </summary>
        /// <param name="enable"> Enable or disable key vault credential setting. </param>
        /// <param name="credentialName"> Credential name. </param>
        /// <param name="azureKeyVaultUri"> Azure Key Vault url. </param>
        /// <param name="servicePrincipalName"> Service principal name to access key vault. </param>
        /// <param name="servicePrincipalSecret"> Service principal name secret to access key vault. </param>
        internal KeyVaultCredentialSettings(bool? enable, string credentialName, Uri azureKeyVaultUri, string servicePrincipalName, string servicePrincipalSecret)
        {
            Enable = enable;
            CredentialName = credentialName;
            AzureKeyVaultUri = azureKeyVaultUri;
            ServicePrincipalName = servicePrincipalName;
            ServicePrincipalSecret = servicePrincipalSecret;
        }

        /// <summary> Enable or disable key vault credential setting. </summary>
        public bool? Enable { get; set; }
        /// <summary> Credential name. </summary>
        public string CredentialName { get; set; }
        /// <summary> Azure Key Vault url. </summary>
        public Uri AzureKeyVaultUri { get; set; }
        /// <summary> Service principal name to access key vault. </summary>
        public string ServicePrincipalName { get; set; }
        /// <summary> Service principal name secret to access key vault. </summary>
        public string ServicePrincipalSecret { get; set; }
    }
}
