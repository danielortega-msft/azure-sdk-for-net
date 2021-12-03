// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Sql.Tests.Mock
{
    /// <summary> Test for PrivateEndpointConnection. </summary>
    public partial class PrivateEndpointConnectionCollectionMockTests : MockTestBase
    {
        public PrivateEndpointConnectionCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Sql.PrivateEndpointConnectionCollection> GetPrivateEndpointConnectionCollectionAsync(string resourceGroupName, string serverName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            PrivateEndpointConnectionCollection privateEndpointConnectionCollection = server.GetPrivateEndpointConnections();
            return privateEndpointConnectionCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Approve or reject a private endpoint connection with a given name.
            var collection = await GetPrivateEndpointConnectionCollectionAsync("Default", "test-svr");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "private-endpoint-connection-name");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Gets private endpoint connection.
            var collection = await GetPrivateEndpointConnectionCollectionAsync("Default", "test-svr");
            await TestHelper.GetExampleInstanceAsync(collection, "private-endpoint-connection-name");
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: Gets list of private endpoint connections on a server.
            var collection = await GetPrivateEndpointConnectionCollectionAsync("Default", "test-svr");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
