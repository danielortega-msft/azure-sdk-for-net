// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the VirtualHub data model. </summary>
    public partial class VirtualHubData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualHubData. </summary>
        public VirtualHubData()
        {
            VirtualHubRouteTableV2S = new ChangeTrackingList<VirtualHubRouteTableV2Data>();
            BgpConnections = new ChangeTrackingList<WritableSubResource>();
            IPConfigurations = new ChangeTrackingList<WritableSubResource>();
            VirtualRouterIPs = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualHubData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualWan"> The VirtualWAN to which the VirtualHub belongs. </param>
        /// <param name="vpnGateway"> The VpnGateway associated with this VirtualHub. </param>
        /// <param name="p2sVpnGateway"> The P2SVpnGateway associated with this VirtualHub. </param>
        /// <param name="expressRouteGateway"> The expressRouteGateway associated with this VirtualHub. </param>
        /// <param name="azureFirewall"> The azureFirewall associated with this VirtualHub. </param>
        /// <param name="securityPartnerProvider"> The securityPartnerProvider associated with this VirtualHub. </param>
        /// <param name="addressPrefix"> Address-prefix for this VirtualHub. </param>
        /// <param name="routeTable"> The routeTable associated with this virtual hub. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual hub resource. </param>
        /// <param name="securityProviderName"> The Security Provider name. </param>
        /// <param name="virtualHubRouteTableV2S"> List of all virtual hub route table v2s associated with this VirtualHub. </param>
        /// <param name="sku"> The sku of this VirtualHub. </param>
        /// <param name="routingState"> The routing state. </param>
        /// <param name="bgpConnections"> List of references to Bgp Connections. </param>
        /// <param name="ipConfigurations"> List of references to IpConfigurations. </param>
        /// <param name="virtualRouterAsn"> VirtualRouter ASN. </param>
        /// <param name="virtualRouterIPs"> VirtualRouter IPs. </param>
        /// <param name="allowBranchToBranchTraffic"> Flag to control transit for VirtualRouter hub. </param>
        /// <param name="preferredRoutingGateway"> The preferred gateway to route on-prem traffic. </param>
        internal VirtualHubData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? etag, WritableSubResource virtualWan, WritableSubResource vpnGateway, WritableSubResource p2sVpnGateway, WritableSubResource expressRouteGateway, WritableSubResource azureFirewall, WritableSubResource securityPartnerProvider, string addressPrefix, VirtualHubRouteTable routeTable, NetworkProvisioningState? provisioningState, string securityProviderName, IList<VirtualHubRouteTableV2Data> virtualHubRouteTableV2S, string sku, RoutingState? routingState, IReadOnlyList<WritableSubResource> bgpConnections, IReadOnlyList<WritableSubResource> ipConfigurations, long? virtualRouterAsn, IList<string> virtualRouterIPs, bool? allowBranchToBranchTraffic, PreferredRoutingGateway? preferredRoutingGateway) : base(id, name, resourceType, location, tags)
        {
            ETag = etag;
            VirtualWan = virtualWan;
            VpnGateway = vpnGateway;
            P2SVpnGateway = p2sVpnGateway;
            ExpressRouteGateway = expressRouteGateway;
            AzureFirewall = azureFirewall;
            SecurityPartnerProvider = securityPartnerProvider;
            AddressPrefix = addressPrefix;
            RouteTable = routeTable;
            ProvisioningState = provisioningState;
            SecurityProviderName = securityProviderName;
            VirtualHubRouteTableV2S = virtualHubRouteTableV2S;
            Sku = sku;
            RoutingState = routingState;
            BgpConnections = bgpConnections;
            IPConfigurations = ipConfigurations;
            VirtualRouterAsn = virtualRouterAsn;
            VirtualRouterIPs = virtualRouterIPs;
            AllowBranchToBranchTraffic = allowBranchToBranchTraffic;
            PreferredRoutingGateway = preferredRoutingGateway;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The VirtualWAN to which the VirtualHub belongs. </summary>
        internal WritableSubResource VirtualWan { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualWanId
        {
            get => VirtualWan is null ? default : VirtualWan.Id;
            set
            {
                if (VirtualWan is null)
                    VirtualWan = new WritableSubResource();
                VirtualWan.Id = value;
            }
        }

        /// <summary> The VpnGateway associated with this VirtualHub. </summary>
        internal WritableSubResource VpnGateway { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VpnGatewayId
        {
            get => VpnGateway is null ? default : VpnGateway.Id;
            set
            {
                if (VpnGateway is null)
                    VpnGateway = new WritableSubResource();
                VpnGateway.Id = value;
            }
        }

        /// <summary> The P2SVpnGateway associated with this VirtualHub. </summary>
        internal WritableSubResource P2SVpnGateway { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier P2SVpnGatewayId
        {
            get => P2SVpnGateway is null ? default : P2SVpnGateway.Id;
            set
            {
                if (P2SVpnGateway is null)
                    P2SVpnGateway = new WritableSubResource();
                P2SVpnGateway.Id = value;
            }
        }

        /// <summary> The expressRouteGateway associated with this VirtualHub. </summary>
        internal WritableSubResource ExpressRouteGateway { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ExpressRouteGatewayId
        {
            get => ExpressRouteGateway is null ? default : ExpressRouteGateway.Id;
            set
            {
                if (ExpressRouteGateway is null)
                    ExpressRouteGateway = new WritableSubResource();
                ExpressRouteGateway.Id = value;
            }
        }

        /// <summary> The azureFirewall associated with this VirtualHub. </summary>
        internal WritableSubResource AzureFirewall { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier AzureFirewallId
        {
            get => AzureFirewall is null ? default : AzureFirewall.Id;
            set
            {
                if (AzureFirewall is null)
                    AzureFirewall = new WritableSubResource();
                AzureFirewall.Id = value;
            }
        }

        /// <summary> The securityPartnerProvider associated with this VirtualHub. </summary>
        internal WritableSubResource SecurityPartnerProvider { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SecurityPartnerProviderId
        {
            get => SecurityPartnerProvider is null ? default : SecurityPartnerProvider.Id;
            set
            {
                if (SecurityPartnerProvider is null)
                    SecurityPartnerProvider = new WritableSubResource();
                SecurityPartnerProvider.Id = value;
            }
        }

        /// <summary> Address-prefix for this VirtualHub. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> The routeTable associated with this virtual hub. </summary>
        internal VirtualHubRouteTable RouteTable { get; set; }
        /// <summary> List of all routes. </summary>
        public IList<VirtualHubRoute> Routes
        {
            get
            {
                if (RouteTable is null)
                    RouteTable = new VirtualHubRouteTable();
                return RouteTable.Routes;
            }
        }

        /// <summary> The provisioning state of the virtual hub resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The Security Provider name. </summary>
        public string SecurityProviderName { get; set; }
        /// <summary> List of all virtual hub route table v2s associated with this VirtualHub. </summary>
        public IList<VirtualHubRouteTableV2Data> VirtualHubRouteTableV2S { get; }
        /// <summary> The sku of this VirtualHub. </summary>
        public string Sku { get; set; }
        /// <summary> The routing state. </summary>
        public RoutingState? RoutingState { get; }
        /// <summary> List of references to Bgp Connections. </summary>
        public IReadOnlyList<WritableSubResource> BgpConnections { get; }
        /// <summary> List of references to IpConfigurations. </summary>
        public IReadOnlyList<WritableSubResource> IPConfigurations { get; }
        /// <summary> VirtualRouter ASN. </summary>
        public long? VirtualRouterAsn { get; set; }
        /// <summary> VirtualRouter IPs. </summary>
        public IList<string> VirtualRouterIPs { get; }
        /// <summary> Flag to control transit for VirtualRouter hub. </summary>
        public bool? AllowBranchToBranchTraffic { get; set; }
        /// <summary> The preferred gateway to route on-prem traffic. </summary>
        public PreferredRoutingGateway? PreferredRoutingGateway { get; set; }
    }
}
