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

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class representing a collection of <see cref="DnsResolverInboundEndpointResource" /> and their operations.
    /// Each <see cref="DnsResolverInboundEndpointResource" /> in the collection will belong to the same instance of <see cref="DnsResolverResource" />.
    /// To get a <see cref="DnsResolverInboundEndpointCollection" /> instance call the GetDnsResolverInboundEndpoints method from an instance of <see cref="DnsResolverResource" />.
    /// </summary>
    public partial class DnsResolverInboundEndpointCollection : ArmCollection, IEnumerable<DnsResolverInboundEndpointResource>, IAsyncEnumerable<DnsResolverInboundEndpointResource>
    {
        private readonly ClientDiagnostics _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics;
        private readonly InboundEndpointsRestOperations _dnsResolverInboundEndpointInboundEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DnsResolverInboundEndpointCollection"/> class for mocking. </summary>
        protected DnsResolverInboundEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DnsResolverInboundEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DnsResolverInboundEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DnsResolver", DnsResolverInboundEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DnsResolverInboundEndpointResource.ResourceType, out string dnsResolverInboundEndpointInboundEndpointsApiVersion);
            _dnsResolverInboundEndpointInboundEndpointsRestClient = new InboundEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dnsResolverInboundEndpointInboundEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DnsResolverResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DnsResolverResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an inbound endpoint for a DNS resolver.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}
        /// Operation Id: InboundEndpoints_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DnsResolverInboundEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string inboundEndpointName, DnsResolverInboundEndpointData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dnsResolverInboundEndpointInboundEndpointsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DnsResolverArmOperation<DnsResolverInboundEndpointResource>(new DnsResolverInboundEndpointOperationSource(Client), _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics, Pipeline, _dnsResolverInboundEndpointInboundEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an inbound endpoint for a DNS resolver.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}
        /// Operation Id: InboundEndpoints_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> ETag of the resource. Omit this value to always overwrite the current resource. Specify the last-seen ETag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new resource to be created, but to prevent updating an existing resource. Other values will be ignored. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DnsResolverInboundEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string inboundEndpointName, DnsResolverInboundEndpointData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dnsResolverInboundEndpointInboundEndpointsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new DnsResolverArmOperation<DnsResolverInboundEndpointResource>(new DnsResolverInboundEndpointOperationSource(Client), _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics, Pipeline, _dnsResolverInboundEndpointInboundEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.Location);
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
        /// Gets properties of an inbound endpoint for a DNS resolver.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}
        /// Operation Id: InboundEndpoints_Get
        /// </summary>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> is null. </exception>
        public virtual async Task<Response<DnsResolverInboundEndpointResource>> GetAsync(string inboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _dnsResolverInboundEndpointInboundEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsResolverInboundEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of an inbound endpoint for a DNS resolver.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}
        /// Operation Id: InboundEndpoints_Get
        /// </summary>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> is null. </exception>
        public virtual Response<DnsResolverInboundEndpointResource> Get(string inboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _dnsResolverInboundEndpointInboundEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsResolverInboundEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists inbound endpoints for a DNS resolver.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints
        /// Operation Id: InboundEndpoints_List
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DnsResolverInboundEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DnsResolverInboundEndpointResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DnsResolverInboundEndpointResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dnsResolverInboundEndpointInboundEndpointsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DnsResolverInboundEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DnsResolverInboundEndpointResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dnsResolverInboundEndpointInboundEndpointsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DnsResolverInboundEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists inbound endpoints for a DNS resolver.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints
        /// Operation Id: InboundEndpoints_List
        /// </summary>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DnsResolverInboundEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DnsResolverInboundEndpointResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<DnsResolverInboundEndpointResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dnsResolverInboundEndpointInboundEndpointsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DnsResolverInboundEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DnsResolverInboundEndpointResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dnsResolverInboundEndpointInboundEndpointsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DnsResolverInboundEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}
        /// Operation Id: InboundEndpoints_Get
        /// </summary>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string inboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dnsResolverInboundEndpointInboundEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsResolvers/{dnsResolverName}/inboundEndpoints/{inboundEndpointName}
        /// Operation Id: InboundEndpoints_Get
        /// </summary>
        /// <param name="inboundEndpointName"> The name of the inbound endpoint for the DNS resolver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inboundEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inboundEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string inboundEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inboundEndpointName, nameof(inboundEndpointName));

            using var scope = _dnsResolverInboundEndpointInboundEndpointsClientDiagnostics.CreateScope("DnsResolverInboundEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _dnsResolverInboundEndpointInboundEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inboundEndpointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DnsResolverInboundEndpointResource> IEnumerable<DnsResolverInboundEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DnsResolverInboundEndpointResource> IAsyncEnumerable<DnsResolverInboundEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
