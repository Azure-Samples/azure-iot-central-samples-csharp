// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The destination reference definition. </summary>
    public partial class DestinationReference
    {
        /// <summary> Initializes a new instance of DestinationReference. </summary>
        /// <param name="id"> The ID of the destination where data should be sent. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public DestinationReference(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Initializes a new instance of DestinationReference. </summary>
        /// <param name="id"> The ID of the destination where data should be sent. </param>
        /// <param name="transform"> Query for transforming the message structure to a particular output. </param>
        internal DestinationReference(string id, string transform)
        {
            Id = id;
            Transform = transform;
        }

        /// <summary> The ID of the destination where data should be sent. </summary>
        public string Id { get; set; }
        /// <summary> Query for transforming the message structure to a particular output. </summary>
        public string Transform { get; set; }
    }
}
