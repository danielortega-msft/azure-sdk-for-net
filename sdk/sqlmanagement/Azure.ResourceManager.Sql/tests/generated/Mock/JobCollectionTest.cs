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
    /// <summary> Test for Job. </summary>
    public partial class JobCollectionMockTests : MockTestBase
    {
        public JobCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<Sql.JobCollection> GetJobCollectionAsync(string resourceGroupName, string serverName, string jobAgentName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            ServerCollection serverCollection = resourceGroup.GetServers();
            var serverOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(serverCollection, serverName);
            Server server = serverOperation.Value;
            JobAgentCollection jobAgentCollection = server.GetJobAgents();
            var jobAgentOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(jobAgentCollection, jobAgentName);
            JobAgent jobAgent = jobAgentOperation.Value;
            JobCollection jobCollection = jobAgent.GetJobs();
            return jobCollection;
        }

        [RecordedTest]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create a job with all properties specified
            var collection = await GetJobCollectionAsync("group1", "server1", "agent1");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "job1");
        }

        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Get a job
            var collection = await GetJobCollectionAsync("group1", "server1", "agent1");
            await TestHelper.GetExampleInstanceAsync(collection, "job1");
        }

        [RecordedTest]
        public async Task GetAllAsync()
        {
            // Example: List jobs in a job agent
            var collection = await GetJobCollectionAsync("group1", "server1", "agent1");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
