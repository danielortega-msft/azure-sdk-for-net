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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of FirewallRule and their operations over its parent. </summary>
    public partial class FirewallRuleCollection : ArmCollection, IEnumerable<FirewallRule>, IAsyncEnumerable<FirewallRule>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FirewallRulesRestOperations _firewallRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="FirewallRuleCollection"/> class for mocking. </summary>
        protected FirewallRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of FirewallRuleCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FirewallRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _firewallRulesRestClient = new FirewallRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Server.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a firewall rule. </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule. </param>
        /// <param name="parameters"> The required parameters for creating or updating a firewall rule. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FirewallRuleCreateOrUpdateOperation CreateOrUpdate(string firewallRuleName, FirewallRuleData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (firewallRuleName == null)
            {
                throw new ArgumentNullException(nameof(firewallRuleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _firewallRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, parameters, cancellationToken);
                var operation = new FirewallRuleCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Creates or updates a firewall rule. </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule. </param>
        /// <param name="parameters"> The required parameters for creating or updating a firewall rule. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FirewallRuleCreateOrUpdateOperation> CreateOrUpdateAsync(string firewallRuleName, FirewallRuleData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (firewallRuleName == null)
            {
                throw new ArgumentNullException(nameof(firewallRuleName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _firewallRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new FirewallRuleCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Gets a firewall rule. </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<FirewallRule> Get(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            if (firewallRuleName == null)
            {
                throw new ArgumentNullException(nameof(firewallRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _firewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FirewallRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a firewall rule. </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public async virtual Task<Response<FirewallRule>> GetAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            if (firewallRuleName == null)
            {
                throw new ArgumentNullException(nameof(firewallRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _firewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FirewallRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<FirewallRule> GetIfExists(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            if (firewallRuleName == null)
            {
                throw new ArgumentNullException(nameof(firewallRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _firewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<FirewallRule>(null, response.GetRawResponse())
                    : Response.FromValue(new FirewallRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public async virtual Task<Response<FirewallRule>> GetIfExistsAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            if (firewallRuleName == null)
            {
                throw new ArgumentNullException(nameof(firewallRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallRuleCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _firewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, firewallRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<FirewallRule>(null, response.GetRawResponse())
                    : Response.FromValue(new FirewallRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            if (firewallRuleName == null)
            {
                throw new ArgumentNullException(nameof(firewallRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallRuleCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(firewallRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="firewallRuleName"> The name of the firewall rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firewallRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string firewallRuleName, CancellationToken cancellationToken = default)
        {
            if (firewallRuleName == null)
            {
                throw new ArgumentNullException(nameof(firewallRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallRuleCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(firewallRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of firewall rules. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FirewallRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FirewallRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FirewallRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _firewallRulesRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FirewallRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _firewallRulesRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of firewall rules. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FirewallRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FirewallRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FirewallRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _firewallRulesRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FirewallRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _firewallRulesRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<FirewallRule> IEnumerable<FirewallRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FirewallRule> IAsyncEnumerable<FirewallRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, FirewallRule, FirewallRuleData> Construct() { }
    }
}
