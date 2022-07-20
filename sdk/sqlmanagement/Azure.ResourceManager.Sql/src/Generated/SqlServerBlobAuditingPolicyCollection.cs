// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerBlobAuditingPolicyResource" /> and their operations.
    /// Each <see cref="SqlServerBlobAuditingPolicyResource" /> in the collection will belong to the same instance of <see cref="SqlServerResource" />.
    /// To get a <see cref="SqlServerBlobAuditingPolicyCollection" /> instance call the GetSqlServerBlobAuditingPolicies method from an instance of <see cref="SqlServerResource" />.
    /// </summary>
    public partial class SqlServerBlobAuditingPolicyCollection : ArmCollection, IEnumerable<SqlServerBlobAuditingPolicyResource>, IAsyncEnumerable<SqlServerBlobAuditingPolicyResource>
    {
        private readonly ClientDiagnostics _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics;
        private readonly ServerBlobAuditingPoliciesRestOperations _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerBlobAuditingPolicyCollection"/> class for mocking. </summary>
        protected SqlServerBlobAuditingPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerBlobAuditingPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerBlobAuditingPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerBlobAuditingPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerBlobAuditingPolicyResource.ResourceType, out string sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesApiVersion);
            _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient = new ServerBlobAuditingPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="data"> Properties of blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerBlobAuditingPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, BlobAuditingPolicyName blobAuditingPolicyName, SqlServerBlobAuditingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SqlServerBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerBlobAuditingPolicyResource>(new SqlServerBlobAuditingPolicyOperationSource(Client), _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics, Pipeline, _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="data"> Properties of blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerBlobAuditingPolicyResource> CreateOrUpdate(WaitUntil waitUntil, BlobAuditingPolicyName blobAuditingPolicyName, SqlServerBlobAuditingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SqlServerBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerBlobAuditingPolicyResource>(new SqlServerBlobAuditingPolicyOperationSource(Client), _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics, Pipeline, _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerBlobAuditingPolicyResource>> GetAsync(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SqlServerBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerBlobAuditingPolicyResource> Get(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SqlServerBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists auditing settings of a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings
        /// Operation Id: ServerBlobAuditingPolicies_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerBlobAuditingPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerBlobAuditingPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlServerBlobAuditingPolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SqlServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerBlobAuditingPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlServerBlobAuditingPolicyResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SqlServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerBlobAuditingPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists auditing settings of a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings
        /// Operation Id: ServerBlobAuditingPolicies_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerBlobAuditingPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerBlobAuditingPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlServerBlobAuditingPolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SqlServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerBlobAuditingPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlServerBlobAuditingPolicyResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SqlServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerBlobAuditingPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SqlServerBlobAuditingPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: ServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SqlServerBlobAuditingPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerBlobAuditingPolicyServerBlobAuditingPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerBlobAuditingPolicyResource> IEnumerable<SqlServerBlobAuditingPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerBlobAuditingPolicyResource> IAsyncEnumerable<SqlServerBlobAuditingPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
