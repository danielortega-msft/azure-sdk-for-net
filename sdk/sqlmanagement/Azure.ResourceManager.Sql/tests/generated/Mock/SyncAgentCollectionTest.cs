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
    /// <summary> Test for SyncAgent. </summary>
    public partial class SyncAgentCollectionMockTests : MockTestBase
    {
        public SyncAgentCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Sql.SyncAgentCollection> GetSyncAgentCollectionAsync(string resourceGroupName, string serverName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            SyncAgentCollection syncAgentCollection = server.GetSyncAgents();
            return syncAgentCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create a new sync agent
            var collection = await GetSyncAgentCollectionAsync("syncagentcrud-65440", "syncagentcrud-8475");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "syncagentcrud-3187");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get a sync agent
            var collection = await GetSyncAgentCollectionAsync("syncagentcrud-65440", "syncagentcrud-8475");
            await TestHelper.GetExampleInstanceAsync(collection, "syncagentcrud-3187");
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: Get sync agents under a server
            var collection = await GetSyncAgentCollectionAsync("syncagentcrud-65440", "syncagentcrud-8475");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
