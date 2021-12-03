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
    /// <summary> Test for ExtendedDatabaseBlobAuditingPolicy. </summary>
    public partial class ExtendedDatabaseBlobAuditingPolicyCollectionMockTests : MockTestBase
    {
        public ExtendedDatabaseBlobAuditingPolicyCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Sql.ExtendedDatabaseBlobAuditingPolicyCollection> GetExtendedDatabaseBlobAuditingPolicyCollectionAsync(string resourceGroupName, string serverName, string databaseName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            DatabaseCollection databaseCollection = server.GetDatabases();
            var databaseOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(databaseCollection, databaseName);
            Database database = databaseOperation.Value;
            ExtendedDatabaseBlobAuditingPolicyCollection extendedDatabaseBlobAuditingPolicyCollection = database.GetExtendedDatabaseBlobAuditingPolicies();
            return extendedDatabaseBlobAuditingPolicyCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create or update an extended database's azure monitor auditing policy with minimal parameters
            var collection = await GetExtendedDatabaseBlobAuditingPolicyCollectionAsync("blobauditingtest-4799", "blobauditingtest-6440", "testdb");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get an extended database's blob auditing policy
            var collection = await GetExtendedDatabaseBlobAuditingPolicyCollectionAsync("blobauditingtest-6852", "blobauditingtest-2080", "testdb");
            await TestHelper.GetExampleInstanceAsync(collection);
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: List extended auditing settings of a database
            var collection = await GetExtendedDatabaseBlobAuditingPolicyCollectionAsync("blobauditingtest-6852", "blobauditingtest-2080", "testdb");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
