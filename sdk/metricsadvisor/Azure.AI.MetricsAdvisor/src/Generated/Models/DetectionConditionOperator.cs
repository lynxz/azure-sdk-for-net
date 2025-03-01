// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary>
    /// condition operator
    /// 
    /// 
    /// 
    /// should be specified when combining multiple detection conditions.
    /// </summary>
    public readonly partial struct DetectionConditionOperator : IEquatable<DetectionConditionOperator>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DetectionConditionOperator"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DetectionConditionOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AndValue = "AND";
        private const string OrValue = "OR";
        /// <summary> Determines if two <see cref="DetectionConditionOperator"/> values are the same. </summary>
        public static bool operator ==(DetectionConditionOperator left, DetectionConditionOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DetectionConditionOperator"/> values are not the same. </summary>
        public static bool operator !=(DetectionConditionOperator left, DetectionConditionOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DetectionConditionOperator"/>. </summary>
        public static implicit operator DetectionConditionOperator(string value) => new DetectionConditionOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DetectionConditionOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DetectionConditionOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
