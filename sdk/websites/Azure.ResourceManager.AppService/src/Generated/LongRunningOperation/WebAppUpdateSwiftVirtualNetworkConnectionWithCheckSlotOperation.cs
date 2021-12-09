// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Description for Integrates this Web App with a Virtual Network. This requires that 1) &quot;swiftSupported&quot; is true when doing a GET against this resource, and 2) that the target Subnet has already been delegated, and is not
    /// in use by another App Service Plan other than the one this App is in.
    /// </summary>
    public partial class WebAppUpdateSwiftVirtualNetworkConnectionWithCheckSlotOperation : Operation<SiteSlotNetworkConfig>
    {
        private readonly OperationOrResponseInternals<SiteSlotNetworkConfig> _operation;

        /// <summary> Initializes a new instance of WebAppUpdateSwiftVirtualNetworkConnectionWithCheckSlotOperation for mocking. </summary>
        protected WebAppUpdateSwiftVirtualNetworkConnectionWithCheckSlotOperation()
        {
        }

        internal WebAppUpdateSwiftVirtualNetworkConnectionWithCheckSlotOperation(ArmResource operationsBase, Response<SwiftVirtualNetworkData> response)
        {
            _operation = new OperationOrResponseInternals<SiteSlotNetworkConfig>(Response.FromValue(new SiteSlotNetworkConfig(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteSlotNetworkConfig Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlotNetworkConfig>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlotNetworkConfig>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
