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
    /// <summary> The query response payload definition. </summary>
    public partial class QueryResponse
    {
        /// <summary> Initializes a new instance of QueryResponse. </summary>
        /// <param name="results"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        internal QueryResponse(IEnumerable<object> results)
        {
            Argument.AssertNotNull(results, nameof(results));

            Results = results.ToList();
        }

        /// <summary> Initializes a new instance of QueryResponse. </summary>
        /// <param name="results"></param>
        internal QueryResponse(IReadOnlyList<object> results)
        {
            Results = results;
        }

        /// <summary> Gets the results. </summary>
        public IReadOnlyList<object> Results { get; }
    }
}
