// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// StaticSiteBasicAuthProperty.
/// </summary>
public partial class StaticSiteBasicAuthProperty : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// State indicating if basic auth is enabled and for what environments it
    /// is active.
    /// </summary>
    public BicepValue<string> ApplicableEnvironmentsMode { get => _applicableEnvironmentsMode; set => _applicableEnvironmentsMode.Assign(value); }
    private readonly BicepValue<string> _applicableEnvironmentsMode;

    /// <summary>
    /// The list of enabled environments for Basic Auth if
    /// ApplicableEnvironmentsMode is set to SpecifiedEnvironments.
    /// </summary>
    public BicepList<string> Environments { get => _environments; set => _environments.Assign(value); }
    private readonly BicepList<string> _environments;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// The password for basic auth.
    /// </summary>
    public BicepValue<string> Password { get => _password; set => _password.Assign(value); }
    private readonly BicepValue<string> _password;

    /// <summary>
    /// Url to the secret in Key Vault.
    /// </summary>
    public BicepValue<Uri> SecretUri { get => _secretUri; set => _secretUri.Assign(value); }
    private readonly BicepValue<Uri> _secretUri;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// State indicating if basic auth has a secret and what type it is.
    /// </summary>
    public BicepValue<string> SecretState { get => _secretState; }
    private readonly BicepValue<string> _secretState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent StaticSite.
    /// </summary>
    public StaticSite? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<StaticSite> _parent;

    /// <summary>
    /// Creates a new StaticSiteBasicAuthProperty.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the StaticSiteBasicAuthProperty
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the StaticSiteBasicAuthProperty.</param>
    public StaticSiteBasicAuthProperty(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Web/staticSites/basicAuth", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _applicableEnvironmentsMode = BicepValue<string>.DefineProperty(this, "ApplicableEnvironmentsMode", ["properties", "applicableEnvironmentsMode"]);
        _environments = BicepList<string>.DefineProperty(this, "Environments", ["properties", "environments"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _password = BicepValue<string>.DefineProperty(this, "Password", ["properties", "password"]);
        _secretUri = BicepValue<Uri>.DefineProperty(this, "SecretUri", ["properties", "secretUrl"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _secretState = BicepValue<string>.DefineProperty(this, "SecretState", ["properties", "secretState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<StaticSite>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported StaticSiteBasicAuthProperty resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

        /// <summary>
        /// 2023-12-01.
        /// </summary>
        public static readonly string V2023_12_01 = "2023-12-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";
    }

    /// <summary>
    /// Creates a reference to an existing StaticSiteBasicAuthProperty.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the StaticSiteBasicAuthProperty
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the StaticSiteBasicAuthProperty.</param>
    /// <returns>The existing StaticSiteBasicAuthProperty resource.</returns>
    public static StaticSiteBasicAuthProperty FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
