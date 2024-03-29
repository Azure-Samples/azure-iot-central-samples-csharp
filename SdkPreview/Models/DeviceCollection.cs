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
    /// <summary> The paged results of devices. </summary>
    internal partial class DeviceCollection
    {
        /// <summary> Initializes a new instance of DeviceCollection. </summary>
        /// <param name="value"> The collection of devices. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DeviceCollection(IEnumerable<Device> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DeviceCollection. </summary>
        /// <param name="value"> The collection of devices. </param>
        /// <param name="nextLink"> URL to get the next page of devices. </param>
        internal DeviceCollection(IReadOnlyList<Device> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of devices. </summary>
        public IReadOnlyList<Device> Value { get; }
        /// <summary> URL to get the next page of devices. </summary>
        public string NextLink { get; }
    }
}
