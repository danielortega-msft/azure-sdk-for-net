// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerConnectionPolicy and their operations over its parent. </summary>
    public partial class ServerConnectionPolicyCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServerConnectionPoliciesRestOperations _serverConnectionPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerConnectionPolicyCollection"/> class for mocking. </summary>
        protected ServerConnectionPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of ServerConnectionPolicyCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerConnectionPolicyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _serverConnectionPoliciesRestClient = new ServerConnectionPoliciesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Server.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates the server&apos;s connection policy. </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="parameters"> The required parameters for updating a secure connection policy. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ServerConnectionPolicyCreateOrUpdateOperation CreateOrUpdate(ConnectionPolicyName connectionPolicyName, ServerConnectionPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerConnectionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverConnectionPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, parameters, cancellationToken);
                var operation = new ServerConnectionPolicyCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the server&apos;s connection policy. </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="parameters"> The required parameters for updating a secure connection policy. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ServerConnectionPolicyCreateOrUpdateOperation> CreateOrUpdateAsync(ConnectionPolicyName connectionPolicyName, ServerConnectionPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerConnectionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverConnectionPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServerConnectionPolicyCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the server&apos;s secure connection policy. </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerConnectionPolicy> Get(ConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerConnectionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _serverConnectionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerConnectionPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the server&apos;s secure connection policy. </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerConnectionPolicy>> GetAsync(ConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerConnectionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverConnectionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerConnectionPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerConnectionPolicy> GetIfExists(ConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerConnectionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverConnectionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServerConnectionPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerConnectionPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerConnectionPolicy>> GetIfExistsAsync(ConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerConnectionPolicyCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _serverConnectionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServerConnectionPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerConnectionPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> CheckIfExists(ConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerConnectionPolicyCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(connectionPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(ConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerConnectionPolicyCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(connectionPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ServerConnectionPolicy, ServerConnectionPolicyData> Construct() { }
    }
}
