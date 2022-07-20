// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The VmGuestPatchClassificationForLinux. </summary>
    public readonly partial struct VmGuestPatchClassificationForLinux : IEquatable<VmGuestPatchClassificationForLinux>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VmGuestPatchClassificationForLinux"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VmGuestPatchClassificationForLinux(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CriticalValue = "Critical";
        private const string SecurityValue = "Security";
        private const string OtherValue = "Other";

        /// <summary> Critical. </summary>
        public static VmGuestPatchClassificationForLinux Critical { get; } = new VmGuestPatchClassificationForLinux(CriticalValue);
        /// <summary> Security. </summary>
        public static VmGuestPatchClassificationForLinux Security { get; } = new VmGuestPatchClassificationForLinux(SecurityValue);
        /// <summary> Other. </summary>
        public static VmGuestPatchClassificationForLinux Other { get; } = new VmGuestPatchClassificationForLinux(OtherValue);
        /// <summary> Determines if two <see cref="VmGuestPatchClassificationForLinux"/> values are the same. </summary>
        public static bool operator ==(VmGuestPatchClassificationForLinux left, VmGuestPatchClassificationForLinux right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VmGuestPatchClassificationForLinux"/> values are not the same. </summary>
        public static bool operator !=(VmGuestPatchClassificationForLinux left, VmGuestPatchClassificationForLinux right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VmGuestPatchClassificationForLinux"/>. </summary>
        public static implicit operator VmGuestPatchClassificationForLinux(string value) => new VmGuestPatchClassificationForLinux(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VmGuestPatchClassificationForLinux other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VmGuestPatchClassificationForLinux other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
