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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of WebSiteInstanceStatus and their operations over its parent. </summary>
    public partial class SiteInstanceCollection : ArmCollection, IEnumerable<SiteInstance>, IAsyncEnumerable<SiteInstance>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteInstanceCollection"/> class for mocking. </summary>
        protected SiteInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteInstanceCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteInstanceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => WebSite.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetInstanceInfo
        /// <summary> Description for Gets all scale-out instances of an app. </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<SiteInstance> Get(string instanceId, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetInstanceInfo(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteInstance(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances/{instanceId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetInstanceInfo
        /// <summary> Description for Gets all scale-out instances of an app. </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<SiteInstance>> GetAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetInstanceInfoAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteInstance(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<SiteInstance> GetIfExists(string instanceId, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetInstanceInfo(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteInstance>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteInstance(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<SiteInstance>> GetIfExistsAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteInstanceCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetInstanceInfoAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteInstance>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteInstance(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string instanceId, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteInstanceCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(instanceId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteInstanceCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListInstanceIdentifiers
        /// <summary> Description for Gets all scale-out instances of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteInstance" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteInstance> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteInstance> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListInstanceIdentifiers(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteInstance> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListInstanceIdentifiersNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/instances
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListInstanceIdentifiers
        /// <summary> Description for Gets all scale-out instances of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteInstance" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteInstance> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteInstance>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListInstanceIdentifiersAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteInstance>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListInstanceIdentifiersNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteInstance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteInstance> IEnumerable<SiteInstance>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteInstance> IAsyncEnumerable<SiteInstance>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SiteInstance, WebSiteInstanceStatusData> Construct() { }
    }
}
