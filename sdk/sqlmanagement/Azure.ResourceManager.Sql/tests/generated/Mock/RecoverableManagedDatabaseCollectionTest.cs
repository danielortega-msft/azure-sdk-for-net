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
    /// <summary> Test for RecoverableManagedDatabase. </summary>
    public partial class RecoverableManagedDatabaseCollectionMockTests : MockTestBase
    {
        public RecoverableManagedDatabaseCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Sql.RecoverableManagedDatabaseCollection> GetRecoverableManagedDatabaseCollectionAsync(string resourceGroupName, string managedInstanceName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ManagedInstanceCollection managedInstanceCollection = resourceGroup.GetManagedInstances();
            var managedInstanceOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(managedInstanceCollection, managedInstanceName);
            ManagedInstance managedInstance = managedInstanceOperation.Value;
            RecoverableManagedDatabaseCollection recoverableManagedDatabaseCollection = managedInstance.GetRecoverableManagedDatabases();
            return recoverableManagedDatabaseCollection;
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Gets a recoverable databases by managed instances
            var collection = await GetRecoverableManagedDatabaseCollectionAsync("Test1", "managedInstance");
            await TestHelper.GetExampleInstanceAsync(collection, "testdb");
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: List recoverable databases by managed instances
            var collection = await GetRecoverableManagedDatabaseCollectionAsync("Test1", "managedInstance");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
