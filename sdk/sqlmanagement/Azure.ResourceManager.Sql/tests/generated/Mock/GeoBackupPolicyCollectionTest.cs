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
    /// <summary> Test for GeoBackupPolicy. </summary>
    public partial class GeoBackupPolicyCollectionMockTests : MockTestBase
    {
        public GeoBackupPolicyCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Sql.GeoBackupPolicyCollection> GetGeoBackupPolicyCollectionAsync(string resourceGroupName, string serverName, string databaseName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            DatabaseCollection databaseCollection = server.GetDatabases();
            var databaseOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(databaseCollection, databaseName);
            Database database = databaseOperation.Value;
            GeoBackupPolicyCollection geoBackupPolicyCollection = database.GetGeoBackupPolicies();
            return geoBackupPolicyCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Update geo backup policy
            var collection = await GetGeoBackupPolicyCollectionAsync("sqlcrudtest-4799", "sqlcrudtest-5961", "testdw");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection);
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get geo backup policy
            var collection = await GetGeoBackupPolicyCollectionAsync("sqlcrudtest-4799", "sqlcrudtest-5961", "testdw");
            await TestHelper.GetExampleInstanceAsync(collection);
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: List geo backup policies
            var collection = await GetGeoBackupPolicyCollectionAsync("sqlcrudtest-4799", "sqlcrudtest-5961", "testdw");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
