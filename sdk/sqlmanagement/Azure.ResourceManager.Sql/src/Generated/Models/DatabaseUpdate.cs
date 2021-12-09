// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A database resource. </summary>
    public partial class DatabaseUpdate
    {
        /// <summary> Initializes a new instance of DatabaseUpdate. </summary>
        public DatabaseUpdate()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The name and tier of the SKU. </summary>
        public Sku Sku { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary>
        /// Specifies the mode of database creation.
        /// 
        /// Default: regular database creation.
        /// 
        /// Copy: creates a database as a copy of an existing database. sourceDatabaseId must be specified as the resource ID of the source database.
        /// 
        /// Secondary: creates a database as a secondary replica of an existing database. sourceDatabaseId must be specified as the resource ID of the existing primary database.
        /// 
        /// PointInTimeRestore: Creates a database by restoring a point in time backup of an existing database. sourceDatabaseId must be specified as the resource ID of the existing database, and restorePointInTime must be specified.
        /// 
        /// Recovery: Creates a database by restoring a geo-replicated backup. sourceDatabaseId must be specified as the recoverable database resource ID to restore.
        /// 
        /// Restore: Creates a database by restoring a backup of a deleted database. sourceDatabaseId must be specified. If sourceDatabaseId is the database&apos;s original resource ID, then sourceDatabaseDeletionDate must be specified. Otherwise sourceDatabaseId must be the restorable dropped database resource ID and sourceDatabaseDeletionDate is ignored. restorePointInTime may also be specified to restore from an earlier point in time.
        /// 
        /// RestoreLongTermRetentionBackup: Creates a database by restoring from a long term retention vault. recoveryServicesRecoveryPointResourceId must be specified as the recovery point resource ID.
        /// 
        /// Copy, Secondary, and RestoreLongTermRetentionBackup are not supported for DataWarehouse edition.
        /// </summary>
        public CreateMode? CreateMode { get; set; }
        /// <summary> The collation of the database. </summary>
        public string Collation { get; set; }
        /// <summary> The max size of the database expressed in bytes. </summary>
        public long? MaxSizeBytes { get; set; }
        /// <summary> The name of the sample schema to apply when creating this database. </summary>
        public SampleSchemaName? SampleName { get; set; }
        /// <summary> The resource identifier of the elastic pool containing this database. </summary>
        public string ElasticPoolId { get; set; }
        /// <summary> The resource identifier of the source database associated with create operation of this database. </summary>
        public string SourceDatabaseId { get; set; }
        /// <summary> The status of the database. </summary>
        public DatabaseStatus? Status { get; }
        /// <summary> The ID of the database. </summary>
        public Guid? DatabaseId { get; }
        /// <summary> The creation date of the database (ISO8601 format). </summary>
        public DateTimeOffset? CreationDate { get; }
        /// <summary> The current service level objective name of the database. </summary>
        public string CurrentServiceObjectiveName { get; }
        /// <summary> The requested service level objective name of the database. </summary>
        public string RequestedServiceObjectiveName { get; }
        /// <summary> The default secondary region for this database. </summary>
        public string DefaultSecondaryLocation { get; }
        /// <summary> Failover Group resource identifier that this database belongs to. </summary>
        public string FailoverGroupId { get; }
        /// <summary> Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </summary>
        public DateTimeOffset? RestorePointInTime { get; set; }
        /// <summary> Specifies the time that the database was deleted. </summary>
        public DateTimeOffset? SourceDatabaseDeletionDate { get; set; }
        /// <summary> The resource identifier of the recovery point associated with create operation of this database. </summary>
        public string RecoveryServicesRecoveryPointId { get; set; }
        /// <summary> The resource identifier of the long term retention backup associated with create operation of this database. </summary>
        public string LongTermRetentionBackupResourceId { get; set; }
        /// <summary> The resource identifier of the recoverable database associated with create operation of this database. </summary>
        public string RecoverableDatabaseId { get; set; }
        /// <summary> The resource identifier of the restorable dropped database associated with create operation of this database. </summary>
        public string RestorableDroppedDatabaseId { get; set; }
        /// <summary> Collation of the metadata catalog. </summary>
        public CatalogCollationType? CatalogCollation { get; set; }
        /// <summary> Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones. </summary>
        public bool? ZoneRedundant { get; set; }
        /// <summary> The license type to apply for this database. `LicenseIncluded` if you need a license, or `BasePrice` if you have a license and are eligible for the Azure Hybrid Benefit. </summary>
        public DatabaseLicenseType? LicenseType { get; set; }
        /// <summary> The max log size for this database. </summary>
        public long? MaxLogSizeBytes { get; }
        /// <summary> This records the earliest start date and time that restore is available for this database (ISO8601 format). </summary>
        public DateTimeOffset? EarliestRestoreDate { get; }
        /// <summary> The state of read-only routing. If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica in the same region. </summary>
        public DatabaseReadScale? ReadScale { get; set; }
        /// <summary> The number of secondary replicas associated with the database that are used to provide high availability. </summary>
        public int? HighAvailabilityReplicaCount { get; set; }
        /// <summary> The secondary type of the database if it is a secondary.  Valid values are Geo and Named. </summary>
        public SecondaryType? SecondaryType { get; set; }
        /// <summary> The name and tier of the SKU. </summary>
        public Sku CurrentSku { get; }
        /// <summary> Time in minutes after which database is automatically paused. A value of -1 means that automatic pause is disabled. </summary>
        public int? AutoPauseDelay { get; set; }
        /// <summary> The storage account type used to store backups for this database. </summary>
        public CurrentBackupStorageRedundancy? CurrentBackupStorageRedundancy { get; }
        /// <summary> The storage account type to be used to store backups for this database. </summary>
        public RequestedBackupStorageRedundancy? RequestedBackupStorageRedundancy { get; set; }
        /// <summary> Minimal capacity that database will always have allocated, if not paused. </summary>
        public double? MinCapacity { get; set; }
        /// <summary> The date when database was paused by user configuration or action(ISO8601 format). Null if the database is ready. </summary>
        public DateTimeOffset? PausedDate { get; }
        /// <summary> The date when database was resumed by user action or database login (ISO8601 format). Null if the database is paused. </summary>
        public DateTimeOffset? ResumedDate { get; }
        /// <summary> Maintenance configuration id assigned to the database. This configuration defines the period when the maintenance updates will occur. </summary>
        public string MaintenanceConfigurationId { get; set; }
        /// <summary> Whether or not this database is a ledger database, which means all tables in the database are ledger tables. Note: the value of this property cannot be changed after the database has been created. </summary>
        public bool? IsLedgerOn { get; set; }
        /// <summary> Infra encryption is enabled for this database. </summary>
        public bool? IsInfraEncryptionEnabled { get; }
    }
}
