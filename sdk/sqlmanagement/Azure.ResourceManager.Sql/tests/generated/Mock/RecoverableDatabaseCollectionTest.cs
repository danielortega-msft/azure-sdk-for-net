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
    /// <summary> Test for RecoverableDatabase. </summary>
    public partial class RecoverableDatabaseCollectionMockTests : MockTestBase
    {
        public RecoverableDatabaseCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Sql.RecoverableDatabaseCollection> GetRecoverableDatabaseCollectionAsync(string resourceGroupName, string serverName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            RecoverableDatabaseCollection recoverableDatabaseCollection = server.GetRecoverableDatabases();
            return recoverableDatabaseCollection;
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get a recoverable database
            var collection = await GetRecoverableDatabaseCollectionAsync("recoverabledatabasetest-6852", "recoverabledatabasetest-2080");
            await TestHelper.GetExampleInstanceAsync(collection, "recoverabledatabasetest-9187");
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: Get list of restorable dropped databases
            var collection = await GetRecoverableDatabaseCollectionAsync("recoverabledatabasetest-1234", "recoverabledatabasetest-7177");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
