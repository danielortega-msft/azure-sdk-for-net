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
    /// A class representing a collection of <see cref="SqlServerAzureADOnlyAuthenticationResource" /> and their operations.
    /// Each <see cref="SqlServerAzureADOnlyAuthenticationResource" /> in the collection will belong to the same instance of <see cref="SqlServerResource" />.
    /// To get a <see cref="SqlServerAzureADOnlyAuthenticationCollection" /> instance call the GetSqlServerAzureADOnlyAuthentications method from an instance of <see cref="SqlServerResource" />.
    /// </summary>
    public partial class SqlServerAzureADOnlyAuthenticationCollection : ArmCollection, IEnumerable<SqlServerAzureADOnlyAuthenticationResource>, IAsyncEnumerable<SqlServerAzureADOnlyAuthenticationResource>
    {
        private readonly ClientDiagnostics _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics;
        private readonly ServerAzureADOnlyAuthenticationsRestOperations _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerAzureADOnlyAuthenticationCollection"/> class for mocking. </summary>
        protected SqlServerAzureADOnlyAuthenticationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerAzureADOnlyAuthenticationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerAzureADOnlyAuthenticationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerAzureADOnlyAuthenticationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerAzureADOnlyAuthenticationResource.ResourceType, out string sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsApiVersion);
            _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient = new ServerAzureADOnlyAuthenticationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsApiVersion);
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
        /// Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="data"> The required parameters for creating or updating an Active Directory only authentication property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerAzureADOnlyAuthenticationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, AuthenticationName authenticationName, SqlServerAzureADOnlyAuthenticationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerAzureADOnlyAuthenticationResource>(new SqlServerAzureADOnlyAuthenticationOperationSource(Client), _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics, Pipeline, _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Sets Server Active Directory only authentication property or updates an existing server Active Directory only authentication property.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="data"> The required parameters for creating or updating an Active Directory only authentication property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerAzureADOnlyAuthenticationResource> CreateOrUpdate(WaitUntil waitUntil, AuthenticationName authenticationName, SqlServerAzureADOnlyAuthenticationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerAzureADOnlyAuthenticationResource>(new SqlServerAzureADOnlyAuthenticationOperationSource(Client), _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics, Pipeline, _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a specific Azure Active Directory only authentication property.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerAzureADOnlyAuthenticationResource>> GetAsync(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAzureADOnlyAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific Azure Active Directory only authentication property.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerAzureADOnlyAuthenticationResource> Get(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAzureADOnlyAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of server Azure Active Directory only authentications.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications
        /// Operation Id: ServerAzureADOnlyAuthentications_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerAzureADOnlyAuthenticationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerAzureADOnlyAuthenticationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlServerAzureADOnlyAuthenticationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerAzureADOnlyAuthenticationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlServerAzureADOnlyAuthenticationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerAzureADOnlyAuthenticationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of server Azure Active Directory only authentications.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications
        /// Operation Id: ServerAzureADOnlyAuthentications_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerAzureADOnlyAuthenticationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerAzureADOnlyAuthenticationResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlServerAzureADOnlyAuthenticationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerAzureADOnlyAuthenticationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlServerAzureADOnlyAuthenticationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlServerAzureADOnlyAuthenticationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/azureADOnlyAuthentications/{authenticationName}
        /// Operation Id: ServerAzureADOnlyAuthentications_Get
        /// </summary>
        /// <param name="authenticationName"> The name of server azure active directory only authentication. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AuthenticationName authenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SqlServerAzureADOnlyAuthenticationCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerAzureADOnlyAuthenticationServerAzureADOnlyAuthenticationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authenticationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerAzureADOnlyAuthenticationResource> IEnumerable<SqlServerAzureADOnlyAuthenticationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerAzureADOnlyAuthenticationResource> IAsyncEnumerable<SqlServerAzureADOnlyAuthenticationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
