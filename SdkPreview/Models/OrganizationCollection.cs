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
    /// <summary> The paged results of organizations. </summary>
    internal partial class OrganizationCollection
    {
        /// <summary> Initializes a new instance of OrganizationCollection. </summary>
        /// <param name="value"> The collection of organizations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal OrganizationCollection(IEnumerable<Organization> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of OrganizationCollection. </summary>
        /// <param name="value"> The collection of organizations. </param>
        /// <param name="nextLink"> URL to get the next page of organizations. </param>
        internal OrganizationCollection(IReadOnlyList<Organization> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of organizations. </summary>
        public IReadOnlyList<Organization> Value { get; }
        /// <summary> URL to get the next page of organizations. </summary>
        public string NextLink { get; }
    }
}
