// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The duration of time to look back when querying data. </summary>
    public readonly partial struct TileTimeRangeDuration : IEquatable<TileTimeRangeDuration>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TileTimeRangeDuration"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TileTimeRangeDuration(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThirtyMinutesValue = "PT30M";
        private const string OneHourValue = "PT1H";
        private const string TwelveHoursValue = "PT12H";
        private const string OneDayValue = "P1D";
        private const string OneWeekValue = "P1W";
        private const string ThirtyDaysValue = "P30D";

        /// <summary> 30 Minutes. </summary>
        public static TileTimeRangeDuration ThirtyMinutes { get; } = new TileTimeRangeDuration(ThirtyMinutesValue);
        /// <summary> 1 Hour. </summary>
        public static TileTimeRangeDuration OneHour { get; } = new TileTimeRangeDuration(OneHourValue);
        /// <summary> 12 Hours. </summary>
        public static TileTimeRangeDuration TwelveHours { get; } = new TileTimeRangeDuration(TwelveHoursValue);
        /// <summary> 1 Day. </summary>
        public static TileTimeRangeDuration OneDay { get; } = new TileTimeRangeDuration(OneDayValue);
        /// <summary> 1 Week. </summary>
        public static TileTimeRangeDuration OneWeek { get; } = new TileTimeRangeDuration(OneWeekValue);
        /// <summary> 30 Days. </summary>
        public static TileTimeRangeDuration ThirtyDays { get; } = new TileTimeRangeDuration(ThirtyDaysValue);
        /// <summary> Determines if two <see cref="TileTimeRangeDuration"/> values are the same. </summary>
        public static bool operator ==(TileTimeRangeDuration left, TileTimeRangeDuration right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TileTimeRangeDuration"/> values are not the same. </summary>
        public static bool operator !=(TileTimeRangeDuration left, TileTimeRangeDuration right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TileTimeRangeDuration"/>. </summary>
        public static implicit operator TileTimeRangeDuration(string value) => new TileTimeRangeDuration(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TileTimeRangeDuration other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TileTimeRangeDuration other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
