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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of VnetGateway and their operations over its parent. </summary>
    public partial class SiteVirtualNetworkConnectionGatewayCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteVirtualNetworkConnectionGatewayCollection"/> class for mocking. </summary>
        protected SiteVirtualNetworkConnectionGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteVirtualNetworkConnectionGatewayCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteVirtualNetworkConnectionGatewayCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SiteVirtualNetworkConnection.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: WebApps_CreateOrUpdateVnetConnectionGateway
        /// <summary> Description for Adds a gateway to a connected Virtual Network (PUT) or updates it (PATCH). </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is &quot;primary&quot;. </param>
        /// <param name="connectionEnvelope"> The properties to update this gateway with. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual WebAppCreateOrUpdateVnetConnectionGatewayOperation CreateOrUpdate(string gatewayName, VnetGatewayData connectionEnvelope, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.CreateOrUpdateVnetConnectionGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, connectionEnvelope, cancellationToken);
                var operation = new WebAppCreateOrUpdateVnetConnectionGatewayOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: WebApps_CreateOrUpdateVnetConnectionGateway
        /// <summary> Description for Adds a gateway to a connected Virtual Network (PUT) or updates it (PATCH). </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is &quot;primary&quot;. </param>
        /// <param name="connectionEnvelope"> The properties to update this gateway with. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="connectionEnvelope"/> is null. </exception>
        public async virtual Task<WebAppCreateOrUpdateVnetConnectionGatewayOperation> CreateOrUpdateAsync(string gatewayName, VnetGatewayData connectionEnvelope, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.CreateOrUpdateVnetConnectionGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new WebAppCreateOrUpdateVnetConnectionGatewayOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: WebApps_GetVnetConnectionGateway
        /// <summary> Description for Gets an app&apos;s Virtual Network gateway. </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is &quot;primary&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<SiteVirtualNetworkConnectionGateway> Get(string gatewayName, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetVnetConnectionGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteVirtualNetworkConnectionGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: WebApps_GetVnetConnectionGateway
        /// <summary> Description for Gets an app&apos;s Virtual Network gateway. </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is &quot;primary&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public async virtual Task<Response<SiteVirtualNetworkConnectionGateway>> GetAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetVnetConnectionGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteVirtualNetworkConnectionGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is &quot;primary&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<SiteVirtualNetworkConnectionGateway> GetIfExists(string gatewayName, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetVnetConnectionGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteVirtualNetworkConnectionGateway>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteVirtualNetworkConnectionGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is &quot;primary&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public async virtual Task<Response<SiteVirtualNetworkConnectionGateway>> GetIfExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetVnetConnectionGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteVirtualNetworkConnectionGateway>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteVirtualNetworkConnectionGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is &quot;primary&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string gatewayName, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(gatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> Name of the gateway. Currently, the only supported string is &quot;primary&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SiteVirtualNetworkConnectionGateway, VnetGatewayData> Construct() { }
    }
}
