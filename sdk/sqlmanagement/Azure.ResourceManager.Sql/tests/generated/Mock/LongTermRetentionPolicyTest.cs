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
    /// <summary> Test for LongTermRetentionPolicy. </summary>
    public partial class LongTermRetentionPolicyMockTests : MockTestBase
    {
        public LongTermRetentionPolicyMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Sql.LongTermRetentionPolicyCollection> GetLongTermRetentionPolicyCollectionAsync(string resourceGroupName, string serverName, string databaseName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            DatabaseCollection databaseCollection = server.GetDatabases();
            var databaseOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(databaseCollection, databaseName);
            Database database = databaseOperation.Value;
            LongTermRetentionPolicyCollection longTermRetentionPolicyCollection = database.GetLongTermRetentionPolicies();
            return longTermRetentionPolicyCollection;
        }

        private async Task<Sql.LongTermRetentionPolicy> GetLongTermRetentionPolicyAsync()
        {
            var collection = await GetLongTermRetentionPolicyCollectionAsync("resourceGroup", "testserver", "testDatabase");
            var createOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(collection);
            return createOperation.Value;
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get the long term retention policy for the database.
            var longTermRetentionPolicy = await GetLongTermRetentionPolicyAsync();

            await longTermRetentionPolicy.GetAsync();
        }
    }
}
