// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Creates or updates an existing Azure Active Directory administrator. </summary>
    public partial class ServerAzureADAdministratorCreateOrUpdateOperation : Operation<ServerAzureADAdministrator>, IOperationSource<ServerAzureADAdministrator>
    {
        private readonly OperationInternals<ServerAzureADAdministrator> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of ServerAzureADAdministratorCreateOrUpdateOperation for mocking. </summary>
        protected ServerAzureADAdministratorCreateOrUpdateOperation()
        {
        }

        internal ServerAzureADAdministratorCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ServerAzureADAdministrator>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ServerAzureADAdministratorCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ServerAzureADAdministrator Value => _operation.Value;

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
        public override ValueTask<Response<ServerAzureADAdministrator>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerAzureADAdministrator>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ServerAzureADAdministrator IOperationSource<ServerAzureADAdministrator>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new ServerAzureADAdministrator(_operationBase, ServerAzureADAdministratorData.DeserializeServerAzureADAdministratorData(document.RootElement));
        }

        async ValueTask<ServerAzureADAdministrator> IOperationSource<ServerAzureADAdministrator>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new ServerAzureADAdministrator(_operationBase, ServerAzureADAdministratorData.DeserializeServerAzureADAdministratorData(document.RootElement));
        }
    }
}
