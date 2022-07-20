// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> A state of a HA server that is visible to user. </summary>
    public readonly partial struct ServerHAState : IEquatable<ServerHAState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServerHAState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServerHAState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotEnabledValue = "NotEnabled";
        private const string CreatingStandbyValue = "CreatingStandby";
        private const string ReplicatingDataValue = "ReplicatingData";
        private const string FailingOverValue = "FailingOver";
        private const string HealthyValue = "Healthy";
        private const string RemovingStandbyValue = "RemovingStandby";

        /// <summary> NotEnabled. </summary>
        public static ServerHAState NotEnabled { get; } = new ServerHAState(NotEnabledValue);
        /// <summary> CreatingStandby. </summary>
        public static ServerHAState CreatingStandby { get; } = new ServerHAState(CreatingStandbyValue);
        /// <summary> ReplicatingData. </summary>
        public static ServerHAState ReplicatingData { get; } = new ServerHAState(ReplicatingDataValue);
        /// <summary> FailingOver. </summary>
        public static ServerHAState FailingOver { get; } = new ServerHAState(FailingOverValue);
        /// <summary> Healthy. </summary>
        public static ServerHAState Healthy { get; } = new ServerHAState(HealthyValue);
        /// <summary> RemovingStandby. </summary>
        public static ServerHAState RemovingStandby { get; } = new ServerHAState(RemovingStandbyValue);
        /// <summary> Determines if two <see cref="ServerHAState"/> values are the same. </summary>
        public static bool operator ==(ServerHAState left, ServerHAState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServerHAState"/> values are not the same. </summary>
        public static bool operator !=(ServerHAState left, ServerHAState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServerHAState"/>. </summary>
        public static implicit operator ServerHAState(string value) => new ServerHAState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServerHAState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServerHAState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
