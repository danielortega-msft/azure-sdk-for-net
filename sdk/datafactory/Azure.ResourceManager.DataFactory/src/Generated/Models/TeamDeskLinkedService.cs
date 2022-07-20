// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for TeamDesk. </summary>
    public partial class TeamDeskLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of TeamDeskLinkedService. </summary>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <param name="uri"> The url to connect TeamDesk source. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public TeamDeskLinkedService(TeamDeskAuthenticationType authenticationType, BinaryData uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            AuthenticationType = authenticationType;
            Uri = uri;
            LinkedServiceType = "TeamDesk";
        }

        /// <summary> Initializes a new instance of TeamDeskLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <param name="uri"> The url to connect TeamDesk source. Type: string (or Expression with resultType string). </param>
        /// <param name="userName"> The username of the TeamDesk source. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// The password of the TeamDesk source.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="apiToken">
        /// The api token for the TeamDesk source.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal TeamDeskLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, TeamDeskAuthenticationType authenticationType, BinaryData uri, BinaryData userName, SecretBase password, SecretBase apiToken, BinaryData encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            AuthenticationType = authenticationType;
            Uri = uri;
            UserName = userName;
            Password = password;
            ApiToken = apiToken;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "TeamDesk";
        }

        /// <summary> The authentication type to use. </summary>
        public TeamDeskAuthenticationType AuthenticationType { get; set; }
        /// <summary> The url to connect TeamDesk source. Type: string (or Expression with resultType string). </summary>
        public BinaryData Uri { get; set; }
        /// <summary> The username of the TeamDesk source. Type: string (or Expression with resultType string). </summary>
        public BinaryData UserName { get; set; }
        /// <summary>
        /// The password of the TeamDesk source.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary>
        /// The api token for the TeamDesk source.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase ApiToken { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
