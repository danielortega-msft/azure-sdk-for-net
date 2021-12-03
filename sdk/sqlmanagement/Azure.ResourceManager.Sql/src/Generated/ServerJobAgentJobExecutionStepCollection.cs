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
    /// <summary> A class representing collection of JobExecution and their operations over its parent. </summary>
    public partial class ServerJobAgentJobExecutionStepCollection : ArmCollection, IEnumerable<ServerJobAgentJobExecutionStep>, IAsyncEnumerable<ServerJobAgentJobExecutionStep>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly JobStepExecutionsRestOperations _jobStepExecutionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerJobAgentJobExecutionStepCollection"/> class for mocking. </summary>
        protected ServerJobAgentJobExecutionStepCollection()
        {
        }

        /// <summary> Initializes a new instance of ServerJobAgentJobExecutionStepCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerJobAgentJobExecutionStepCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _jobStepExecutionsRestClient = new JobStepExecutionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ServerJobAgentJobExecution.ResourceType;

        // Collection level operations.

        /// <summary> Gets a step execution of a job execution. </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual Response<ServerJobAgentJobExecutionStep> Get(string stepName, CancellationToken cancellationToken = default)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepCollection.Get");
            scope.Start();
            try
            {
                var response = _jobStepExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), stepName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerJobAgentJobExecutionStep(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a step execution of a job execution. </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public async virtual Task<Response<ServerJobAgentJobExecutionStep>> GetAsync(string stepName, CancellationToken cancellationToken = default)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepCollection.Get");
            scope.Start();
            try
            {
                var response = await _jobStepExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), stepName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerJobAgentJobExecutionStep(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual Response<ServerJobAgentJobExecutionStep> GetIfExists(string stepName, CancellationToken cancellationToken = default)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _jobStepExecutionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), stepName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServerJobAgentJobExecutionStep>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerJobAgentJobExecutionStep(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public async virtual Task<Response<ServerJobAgentJobExecutionStep>> GetIfExistsAsync(string stepName, CancellationToken cancellationToken = default)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _jobStepExecutionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), stepName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServerJobAgentJobExecutionStep>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerJobAgentJobExecutionStep(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string stepName, CancellationToken cancellationToken = default)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(stepName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="stepName"> The name of the step. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stepName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string stepName, CancellationToken cancellationToken = default)
        {
            if (stepName == null)
            {
                throw new ArgumentNullException(nameof(stepName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(stepName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the step executions of a job execution. </summary>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerJobAgentJobExecutionStep" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerJobAgentJobExecutionStep> GetAll(DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ServerJobAgentJobExecutionStep> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobStepExecutionsRestClient.ListByJobExecution(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStep(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerJobAgentJobExecutionStep> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _jobStepExecutionsRestClient.ListByJobExecutionNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStep(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the step executions of a job execution. </summary>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerJobAgentJobExecutionStep" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerJobAgentJobExecutionStep> GetAllAsync(DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerJobAgentJobExecutionStep>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobStepExecutionsRestClient.ListByJobExecutionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStep(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerJobAgentJobExecutionStep>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerJobAgentJobExecutionStepCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _jobStepExecutionsRestClient.ListByJobExecutionNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Guid.Parse(Id.Name), createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerJobAgentJobExecutionStep(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ServerJobAgentJobExecutionStep> IEnumerable<ServerJobAgentJobExecutionStep>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerJobAgentJobExecutionStep> IAsyncEnumerable<ServerJobAgentJobExecutionStep>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ServerJobAgentJobExecutionStep, JobExecutionData> Construct() { }
    }
}
