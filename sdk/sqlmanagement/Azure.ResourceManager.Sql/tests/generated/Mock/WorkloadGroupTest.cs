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
    /// <summary> Test for WorkloadGroup. </summary>
    public partial class WorkloadGroupMockTests : MockTestBase
    {
        public WorkloadGroupMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Sql.WorkloadGroupCollection> GetWorkloadGroupCollectionAsync(string resourceGroupName, string serverName, string databaseName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            DatabaseCollection databaseCollection = server.GetDatabases();
            var databaseOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(databaseCollection, databaseName);
            Database database = databaseOperation.Value;
            WorkloadGroupCollection workloadGroupCollection = database.GetWorkloadGroups();
            return workloadGroupCollection;
        }

        private async Task<Sql.WorkloadGroup> GetWorkloadGroupAsync()
        {
            var collection = await GetWorkloadGroupCollectionAsync("Default-SQL-SouthEastAsia", "testsvr", "testdb");
            var createOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "smallrc");
            return createOperation.Value;
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Gets a workload group for a data warehouse
            var workloadGroup = await GetWorkloadGroupAsync();

            await workloadGroup.GetAsync();
        }

        [RecordedTest]
        public async Task DeleteAsync()
        {
            // Example: Delete a workload group
            var workloadGroup = await GetWorkloadGroupAsync();

            await workloadGroup.DeleteAsync();
        }
    }
}
