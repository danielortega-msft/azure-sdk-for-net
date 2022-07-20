// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Provisioning state of the certificate. </summary>
    public readonly partial struct CertificateProvisioningState : IEquatable<CertificateProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CertificateProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CertificateProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeleteFailedValue = "DeleteFailed";
        private const string PendingValue = "Pending";

        /// <summary> Succeeded. </summary>
        public static CertificateProvisioningState Succeeded { get; } = new CertificateProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static CertificateProvisioningState Failed { get; } = new CertificateProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static CertificateProvisioningState Canceled { get; } = new CertificateProvisioningState(CanceledValue);
        /// <summary> DeleteFailed. </summary>
        public static CertificateProvisioningState DeleteFailed { get; } = new CertificateProvisioningState(DeleteFailedValue);
        /// <summary> Pending. </summary>
        public static CertificateProvisioningState Pending { get; } = new CertificateProvisioningState(PendingValue);
        /// <summary> Determines if two <see cref="CertificateProvisioningState"/> values are the same. </summary>
        public static bool operator ==(CertificateProvisioningState left, CertificateProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CertificateProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(CertificateProvisioningState left, CertificateProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CertificateProvisioningState"/>. </summary>
        public static implicit operator CertificateProvisioningState(string value) => new CertificateProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CertificateProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CertificateProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
