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
    /// <summary> Test for ManagedInstanceLongTermRetentionPolicy. </summary>
    public partial class ManagedInstanceLongTermRetentionPolicyMockTests : MockTestBase
    {
        public ManagedInstanceLongTermRetentionPolicyMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Sql.ManagedInstanceLongTermRetentionPolicyCollection> GetManagedInstanceLongTermRetentionPolicyCollectionAsync(string resourceGroupName, string managedInstanceName, string databaseName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ManagedInstanceCollection managedInstanceCollection = resourceGroup.GetManagedInstances();
            var managedInstanceOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(managedInstanceCollection, managedInstanceName);
            ManagedInstance managedInstance = managedInstanceOperation.Value;
            ManagedDatabaseCollection managedDatabaseCollection = managedInstance.GetManagedDatabases();
            var managedDatabaseOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(managedDatabaseCollection, databaseName);
            ManagedDatabase managedDatabase = managedDatabaseOperation.Value;
            ManagedInstanceLongTermRetentionPolicyCollection managedInstanceLongTermRetentionPolicyCollection = managedDatabase.GetManagedInstanceLongTermRetentionPolicies();
            return managedInstanceLongTermRetentionPolicyCollection;
        }

        private async Task<Sql.ManagedInstanceLongTermRetentionPolicy> GetManagedInstanceLongTermRetentionPolicyAsync()
        {
            var collection = await GetManagedInstanceLongTermRetentionPolicyCollectionAsync("testResourceGroup", "testInstance", "testDatabase");
            var createOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(collection);
            return createOperation.Value;
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get the long term retention policy for the managed database.
            var managedInstanceLongTermRetentionPolicy = await GetManagedInstanceLongTermRetentionPolicyAsync();

            await managedInstanceLongTermRetentionPolicy.GetAsync();
        }
    }
}
