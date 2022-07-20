// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
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
    public readonly partial struct SqlDatabaseCreateMode : IEquatable<SqlDatabaseCreateMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlDatabaseCreateMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlDatabaseCreateMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string CopyValue = "Copy";
        private const string SecondaryValue = "Secondary";
        private const string PointInTimeRestoreValue = "PointInTimeRestore";
        private const string RestoreValue = "Restore";
        private const string RecoveryValue = "Recovery";
        private const string RestoreExternalBackupValue = "RestoreExternalBackup";
        private const string RestoreExternalBackupSecondaryValue = "RestoreExternalBackupSecondary";
        private const string RestoreLongTermRetentionBackupValue = "RestoreLongTermRetentionBackup";
        private const string OnlineSecondaryValue = "OnlineSecondary";

        /// <summary> Default. </summary>
        public static SqlDatabaseCreateMode Default { get; } = new SqlDatabaseCreateMode(DefaultValue);
        /// <summary> Copy. </summary>
        public static SqlDatabaseCreateMode Copy { get; } = new SqlDatabaseCreateMode(CopyValue);
        /// <summary> Secondary. </summary>
        public static SqlDatabaseCreateMode Secondary { get; } = new SqlDatabaseCreateMode(SecondaryValue);
        /// <summary> PointInTimeRestore. </summary>
        public static SqlDatabaseCreateMode PointInTimeRestore { get; } = new SqlDatabaseCreateMode(PointInTimeRestoreValue);
        /// <summary> Restore. </summary>
        public static SqlDatabaseCreateMode Restore { get; } = new SqlDatabaseCreateMode(RestoreValue);
        /// <summary> Recovery. </summary>
        public static SqlDatabaseCreateMode Recovery { get; } = new SqlDatabaseCreateMode(RecoveryValue);
        /// <summary> RestoreExternalBackup. </summary>
        public static SqlDatabaseCreateMode RestoreExternalBackup { get; } = new SqlDatabaseCreateMode(RestoreExternalBackupValue);
        /// <summary> RestoreExternalBackupSecondary. </summary>
        public static SqlDatabaseCreateMode RestoreExternalBackupSecondary { get; } = new SqlDatabaseCreateMode(RestoreExternalBackupSecondaryValue);
        /// <summary> RestoreLongTermRetentionBackup. </summary>
        public static SqlDatabaseCreateMode RestoreLongTermRetentionBackup { get; } = new SqlDatabaseCreateMode(RestoreLongTermRetentionBackupValue);
        /// <summary> OnlineSecondary. </summary>
        public static SqlDatabaseCreateMode OnlineSecondary { get; } = new SqlDatabaseCreateMode(OnlineSecondaryValue);
        /// <summary> Determines if two <see cref="SqlDatabaseCreateMode"/> values are the same. </summary>
        public static bool operator ==(SqlDatabaseCreateMode left, SqlDatabaseCreateMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlDatabaseCreateMode"/> values are not the same. </summary>
        public static bool operator !=(SqlDatabaseCreateMode left, SqlDatabaseCreateMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlDatabaseCreateMode"/>. </summary>
        public static implicit operator SqlDatabaseCreateMode(string value) => new SqlDatabaseCreateMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlDatabaseCreateMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlDatabaseCreateMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
