// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Storage.Models
{
    /// <summary> The signed permissions for the account SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p). </summary>
    public readonly partial struct Permission : IEquatable<Permission>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Permission"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Permission(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RValue = "r";
        private const string DValue = "d";
        private const string WValue = "w";
        private const string LValue = "l";
        private const string AValue = "a";
        private const string CValue = "c";
        private const string UValue = "u";
        private const string PValue = "p";

        /// <summary> r. </summary>
        public static Permission R { get; } = new Permission(RValue);
        /// <summary> d. </summary>
        public static Permission D { get; } = new Permission(DValue);
        /// <summary> w. </summary>
        public static Permission W { get; } = new Permission(WValue);
        /// <summary> l. </summary>
        public static Permission L { get; } = new Permission(LValue);
        /// <summary> a. </summary>
        public static Permission A { get; } = new Permission(AValue);
        /// <summary> c. </summary>
        public static Permission C { get; } = new Permission(CValue);
        /// <summary> u. </summary>
        public static Permission U { get; } = new Permission(UValue);
        /// <summary> p. </summary>
        public static Permission P { get; } = new Permission(PValue);
        /// <summary> Determines if two <see cref="Permission"/> values are the same. </summary>
        public static bool operator ==(Permission left, Permission right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Permission"/> values are not the same. </summary>
        public static bool operator !=(Permission left, Permission right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Permission"/>. </summary>
        public static implicit operator Permission(string value) => new Permission(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Permission other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Permission other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}