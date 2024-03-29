// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    internal static partial class JobBatchTypeExtensions
    {
        public static string ToSerialString(this JobBatchType value) => value switch
        {
            JobBatchType.Number => "number",
            JobBatchType.Percentage => "percentage",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown JobBatchType value.")
        };

        public static JobBatchType ToJobBatchType(this string value)
        {
            if (string.Equals(value, "number", StringComparison.InvariantCultureIgnoreCase)) return JobBatchType.Number;
            if (string.Equals(value, "percentage", StringComparison.InvariantCultureIgnoreCase)) return JobBatchType.Percentage;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown JobBatchType value.");
        }
    }
}
