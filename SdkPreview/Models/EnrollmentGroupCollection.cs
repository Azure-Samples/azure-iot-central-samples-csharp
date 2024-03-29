// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The paged results of enrollment groups. </summary>
    internal partial class EnrollmentGroupCollection
    {
        /// <summary> Initializes a new instance of EnrollmentGroupCollection. </summary>
        /// <param name="value"> The collection of enrollment groups. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal EnrollmentGroupCollection(IEnumerable<EnrollmentGroup> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of EnrollmentGroupCollection. </summary>
        /// <param name="value"> The collection of enrollment groups. </param>
        /// <param name="nextLink"> URL to get the next page of enrollment groups. </param>
        internal EnrollmentGroupCollection(IReadOnlyList<EnrollmentGroup> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of enrollment groups. </summary>
        public IReadOnlyList<EnrollmentGroup> Value { get; }
        /// <summary> URL to get the next page of enrollment groups. </summary>
        public string NextLink { get; }
    }
}
