// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// JitRequest.
/// </summary>
public partial class JitRequest : Resource
{
    /// <summary>
    /// The name of the JIT request.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The parent application id.
    /// </summary>
    public BicepValue<string> ApplicationResourceId { get => _applicationResourceId; set => _applicationResourceId.Assign(value); }
    private readonly BicepValue<string> _applicationResourceId;

    /// <summary>
    /// The JIT authorization policies.
    /// </summary>
    public BicepList<JitAuthorizationPolicies> JitAuthorizationPolicies { get => _jitAuthorizationPolicies; set => _jitAuthorizationPolicies.Assign(value); }
    private readonly BicepList<JitAuthorizationPolicies> _jitAuthorizationPolicies;

    /// <summary>
    /// The JIT request properties.
    /// </summary>
    public BicepValue<JitSchedulingPolicy> JitSchedulingPolicy { get => _jitSchedulingPolicy; set => _jitSchedulingPolicy.Assign(value); }
    private readonly BicepValue<JitSchedulingPolicy> _jitSchedulingPolicy;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// The client entity that created the JIT request.
    /// </summary>
    public BicepValue<ArmApplicationDetails> CreatedBy { get => _createdBy; }
    private readonly BicepValue<ArmApplicationDetails> _createdBy;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The JIT request state.
    /// </summary>
    public BicepValue<JitRequestState> JitRequestState { get => _jitRequestState; }
    private readonly BicepValue<JitRequestState> _jitRequestState;

    /// <summary>
    /// The JIT request provisioning state.
    /// </summary>
    public BicepValue<ResourcesProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ResourcesProvisioningState> _provisioningState;

    /// <summary>
    /// The publisher tenant id.
    /// </summary>
    public BicepValue<Guid> PublisherTenantId { get => _publisherTenantId; }
    private readonly BicepValue<Guid> _publisherTenantId;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// The client entity that last updated the JIT request.
    /// </summary>
    public BicepValue<ArmApplicationDetails> UpdatedBy { get => _updatedBy; }
    private readonly BicepValue<ArmApplicationDetails> _updatedBy;

    /// <summary>
    /// Creates a new JitRequest.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the JitRequest resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the JitRequest.</param>
    public JitRequest(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Solutions/jitRequests", resourceVersion ?? "2021-07-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _applicationResourceId = BicepValue<string>.DefineProperty(this, "ApplicationResourceId", ["properties", "applicationResourceId"]);
        _jitAuthorizationPolicies = BicepList<JitAuthorizationPolicies>.DefineProperty(this, "JitAuthorizationPolicies", ["properties", "jitAuthorizationPolicies"]);
        _jitSchedulingPolicy = BicepValue<JitSchedulingPolicy>.DefineProperty(this, "JitSchedulingPolicy", ["properties", "jitSchedulingPolicy"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _createdBy = BicepValue<ArmApplicationDetails>.DefineProperty(this, "CreatedBy", ["properties", "createdBy"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _jitRequestState = BicepValue<JitRequestState>.DefineProperty(this, "JitRequestState", ["properties", "jitRequestState"], isOutput: true);
        _provisioningState = BicepValue<ResourcesProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _publisherTenantId = BicepValue<Guid>.DefineProperty(this, "PublisherTenantId", ["properties", "publisherTenantId"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _updatedBy = BicepValue<ArmApplicationDetails>.DefineProperty(this, "UpdatedBy", ["properties", "updatedBy"], isOutput: true);
    }

    /// <summary>
    /// Supported JitRequest resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-07-01.
        /// </summary>
        public static readonly string V2021_07_01 = "2021-07-01";

        /// <summary>
        /// 2019-07-01.
        /// </summary>
        public static readonly string V2019_07_01 = "2019-07-01";
    }

    /// <summary>
    /// Creates a reference to an existing JitRequest.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the JitRequest resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the JitRequest.</param>
    /// <returns>The existing JitRequest resource.</returns>
    public static JitRequest FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
