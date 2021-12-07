// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a PublicIPAddress along with the instance operations that can be performed on it. </summary>
    public partial class PublicIPAddress : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PublicIPAddressesRestOperations _publicIPAddressesRestClient;
        private readonly PublicIPAddressData _data;

        /// <summary> Initializes a new instance of the <see cref="PublicIPAddress"/> class for mocking. </summary>
        protected PublicIPAddress()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PublicIPAddress"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal PublicIPAddress(ArmResource options, PublicIPAddressData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _publicIPAddressesRestClient = new PublicIPAddressesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="PublicIPAddress"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PublicIPAddress(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _publicIPAddressesRestClient = new PublicIPAddressesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="PublicIPAddress"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PublicIPAddress(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _publicIPAddressesRestClient = new PublicIPAddressesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/publicIPAddresses";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PublicIPAddressData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the specified public IP address in a specified resource group. </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<PublicIPAddress>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPAddress.Get");
            scope.Start();
            try
            {
                var response = await _publicIPAddressesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PublicIPAddress(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified public IP address in a specified resource group. </summary>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PublicIPAddress> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPAddress.Get");
            scope.Start();
            try
            {
                var response = _publicIPAddressesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublicIPAddress(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes the specified public IP address. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<PublicIPAddressDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPAddress.Delete");
            scope.Start();
            try
            {
                var response = await _publicIPAddressesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new PublicIPAddressDeleteOperation(_clientDiagnostics, Pipeline, _publicIPAddressesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified public IP address. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PublicIPAddressDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPAddress.Delete");
            scope.Start();
            try
            {
                var response = _publicIPAddressesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new PublicIPAddressDeleteOperation(_clientDiagnostics, Pipeline, _publicIPAddressesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
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

        /// <summary> Updates public IP address tags. </summary>
        /// <param name="parameters"> Parameters supplied to update public IP address tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<PublicIPAddress>> UpdateAsync(TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddress.Update");
            scope.Start();
            try
            {
                var response = await _publicIPAddressesRestClient.UpdateTagsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PublicIPAddress(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates public IP address tags. </summary>
        /// <param name="parameters"> Parameters supplied to update public IP address tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<PublicIPAddress> Update(TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddress.Update");
            scope.Start();
            try
            {
                var response = _publicIPAddressesRestClient.UpdateTags(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return Response.FromValue(new PublicIPAddress(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
