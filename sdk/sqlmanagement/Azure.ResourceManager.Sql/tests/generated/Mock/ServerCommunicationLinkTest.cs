// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for ServerCommunicationLink. </summary>
    public partial class ServerCommunicationLinkMockTests : MockTestBase
    {
        public ServerCommunicationLinkMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Sql.ServerCommunicationLinkCollection> GetServerCommunicationLinkCollectionAsync(string resourceGroupName, string serverName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            ServerCommunicationLinkCollection serverCommunicationLinkCollection = server.GetServerCommunicationLinks();
            return serverCommunicationLinkCollection;
        }

        private async Task<Sql.ServerCommunicationLink> GetServerCommunicationLinkAsync()
        {
            var collection = await GetServerCommunicationLinkCollectionAsync("sqlcrudtest-7398", "sqlcrudtest-4645");
            var createOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "link1");
            return createOperation.Value;
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get a server communication link
            var serverCommunicationLink = await GetServerCommunicationLinkAsync();

            await serverCommunicationLink.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete a server communication link
            var serverCommunicationLink = await GetServerCommunicationLinkAsync();

            await serverCommunicationLink.DeleteAsync();
        }
    }
}
