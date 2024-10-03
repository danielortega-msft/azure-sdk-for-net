// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// FileService.
/// </summary>
public partial class FileService : Resource
{
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The List of CORS rules. You can include up to five CorsRule elements in
    /// the request.
    /// </summary>
    public BicepList<StorageCorsRule> CorsRules { get => _corsRules; set => _corsRules.Assign(value); }
    private readonly BicepList<StorageCorsRule> _corsRules;

    /// <summary>
    /// Setting for SMB protocol.
    /// </summary>
    public BicepValue<SmbSetting> ProtocolSmbSetting { get => _protocolSmbSetting; set => _protocolSmbSetting.Assign(value); }
    private readonly BicepValue<SmbSetting> _protocolSmbSetting;

    /// <summary>
    /// The file service properties for share soft delete.
    /// </summary>
    public BicepValue<DeleteRetentionPolicy> ShareDeleteRetentionPolicy { get => _shareDeleteRetentionPolicy; set => _shareDeleteRetentionPolicy.Assign(value); }
    private readonly BicepValue<DeleteRetentionPolicy> _shareDeleteRetentionPolicy;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Sku name and tier.
    /// </summary>
    public BicepValue<StorageSku> Sku { get => _sku; }
    private readonly BicepValue<StorageSku> _sku;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent StorageAccount.
    /// </summary>
    public StorageAccount? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<StorageAccount> _parent;

    /// <summary>
    /// Get the default value for the Name property.
    /// </summary>
    private partial BicepValue<string> GetNameDefaultValue();

    /// <summary>
    /// Creates a new FileService.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the FileService resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the FileService.</param>
    public FileService(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Storage/storageAccounts/fileServices", resourceVersion ?? "2024-01-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], defaultValue: GetNameDefaultValue());
        _corsRules = BicepList<StorageCorsRule>.DefineProperty(this, "CorsRules", ["properties", "cors", "corsRules"]);
        _protocolSmbSetting = BicepValue<SmbSetting>.DefineProperty(this, "ProtocolSmbSetting", ["properties", "protocolSettings", "smb"]);
        _shareDeleteRetentionPolicy = BicepValue<DeleteRetentionPolicy>.DefineProperty(this, "ShareDeleteRetentionPolicy", ["properties", "shareDeleteRetentionPolicy"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _sku = BicepValue<StorageSku>.DefineProperty(this, "Sku", ["sku"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<StorageAccount>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported FileService resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2021-08-01.
        /// </summary>
        public static readonly string V2021_08_01 = "2021-08-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2021-05-01.
        /// </summary>
        public static readonly string V2021_05_01 = "2021-05-01";

        /// <summary>
        /// 2021-04-01.
        /// </summary>
        public static readonly string V2021_04_01 = "2021-04-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-07-01.
        /// </summary>
        public static readonly string V2018_07_01 = "2018-07-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-06-01.
        /// </summary>
        public static readonly string V2017_06_01 = "2017-06-01";

        /// <summary>
        /// 2016-12-01.
        /// </summary>
        public static readonly string V2016_12_01 = "2016-12-01";

        /// <summary>
        /// 2016-05-01.
        /// </summary>
        public static readonly string V2016_05_01 = "2016-05-01";
    }

    /// <summary>
    /// Creates a reference to an existing FileService.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the FileService resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the FileService.</param>
    /// <returns>The existing FileService resource.</returns>
    public static FileService FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
