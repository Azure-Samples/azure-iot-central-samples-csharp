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
    /// <summary> The paged results of destinations. </summary>
    internal partial class DestinationCollection
    {
        /// <summary> Initializes a new instance of DestinationCollection. </summary>
        /// <param name="value"> The collection of destinations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DestinationCollection(IEnumerable<Destination> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DestinationCollection. </summary>
        /// <param name="value"> The collection of destinations. </param>
        /// <param name="nextLink"> URL to get the next page of destinations. </param>
        internal DestinationCollection(IReadOnlyList<Destination> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of destinations. </summary>
        public IReadOnlyList<Destination> Value { get; }
        /// <summary> URL to get the next page of destinations. </summary>
        public string NextLink { get; }
    }
}
