// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IP address version. </summary>
    public readonly partial struct NetworkIPVersion : IEquatable<NetworkIPVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkIPVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkIPVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IPv4Value = "IPv4";
        private const string IPv6Value = "IPv6";

        /// <summary> IPv4. </summary>
        public static NetworkIPVersion IPv4 { get; } = new NetworkIPVersion(IPv4Value);
        /// <summary> IPv6. </summary>
        public static NetworkIPVersion IPv6 { get; } = new NetworkIPVersion(IPv6Value);
        /// <summary> Determines if two <see cref="NetworkIPVersion"/> values are the same. </summary>
        public static bool operator ==(NetworkIPVersion left, NetworkIPVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkIPVersion"/> values are not the same. </summary>
        public static bool operator !=(NetworkIPVersion left, NetworkIPVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkIPVersion"/>. </summary>
        public static implicit operator NetworkIPVersion(string value) => new NetworkIPVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkIPVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkIPVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
