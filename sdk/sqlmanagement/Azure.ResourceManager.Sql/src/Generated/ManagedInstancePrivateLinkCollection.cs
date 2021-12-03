// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ManagedInstancePrivateLink and their operations over its parent. </summary>
    public partial class ManagedInstancePrivateLinkCollection : ArmCollection, IEnumerable<ManagedInstancePrivateLink>, IAsyncEnumerable<ManagedInstancePrivateLink>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedInstancePrivateLinkResourcesRestOperations _managedInstancePrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstancePrivateLinkCollection"/> class for mocking. </summary>
        protected ManagedInstancePrivateLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstancePrivateLinkCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagedInstancePrivateLinkCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedInstancePrivateLinkResourcesRestClient = new ManagedInstancePrivateLinkResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ManagedInstance.ResourceType;

        // Collection level operations.

        /// <summary> Gets a private link resource for SQL server. </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<ManagedInstancePrivateLink> Get(string groupName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstancePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstancePrivateLink(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a private link resource for SQL server. </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public async virtual Task<Response<ManagedInstancePrivateLink>> GetAsync(string groupName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstancePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstancePrivateLink(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<ManagedInstancePrivateLink> GetIfExists(string groupName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstancePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ManagedInstancePrivateLink>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedInstancePrivateLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public async virtual Task<Response<ManagedInstancePrivateLink>> GetIfExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _managedInstancePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ManagedInstancePrivateLink>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedInstancePrivateLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string groupName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(groupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="groupName"> The name of the private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="groupName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string groupName, CancellationToken cancellationToken = default)
        {
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(groupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the private link resources for SQL server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstancePrivateLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstancePrivateLink> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedInstancePrivateLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstancePrivateLinkResourcesRestClient.ListByManagedInstance(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstancePrivateLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstancePrivateLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedInstancePrivateLinkResourcesRestClient.ListByManagedInstanceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstancePrivateLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the private link resources for SQL server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstancePrivateLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstancePrivateLink> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstancePrivateLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstancePrivateLinkResourcesRestClient.ListByManagedInstanceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstancePrivateLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstancePrivateLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstancePrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedInstancePrivateLinkResourcesRestClient.ListByManagedInstanceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstancePrivateLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ManagedInstancePrivateLink> IEnumerable<ManagedInstancePrivateLink>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstancePrivateLink> IAsyncEnumerable<ManagedInstancePrivateLink>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ManagedInstancePrivateLink, ManagedInstancePrivateLinkData> Construct() { }
    }
}
