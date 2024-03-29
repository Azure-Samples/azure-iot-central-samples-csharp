// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The blob storage destination definition. </summary>
    public partial class BlobStorageV1Destination : Destination
    {
        /// <summary> Initializes a new instance of BlobStorageV1Destination. </summary>
        /// <param name="displayName"> Display name of the destination. </param>
        /// <param name="authorization"> The authentication definition for blob storage destination. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/> or <paramref name="authorization"/> is null. </exception>
        public BlobStorageV1Destination(string displayName, BlobStorageV1DestinationAuth authorization) : base(displayName)
        {
            Argument.AssertNotNull(displayName, nameof(displayName));
            Argument.AssertNotNull(authorization, nameof(authorization));

            Authorization = authorization;
            Type = "blobstorage@v1";
        }

        /// <summary> Initializes a new instance of BlobStorageV1Destination. </summary>
        /// <param name="status"> Indication of the current health and operation of the export or destination. </param>
        /// <param name="errors"> Errors encountered by the export or destination. </param>
        /// <param name="lastExportTime"> The timestamp of the last message that was sent to the export or destination. </param>
        /// <param name="id"> Unique ID of the destination. </param>
        /// <param name="displayName"> Display name of the destination. </param>
        /// <param name="type"> The type of destination configuration. </param>
        /// <param name="authorization"> The authentication definition for blob storage destination. </param>
        internal BlobStorageV1Destination(string status, IReadOnlyList<DataExportError> errors, DateTimeOffset? lastExportTime, string id, string displayName, string type, BlobStorageV1DestinationAuth authorization) : base(status, errors, lastExportTime, id, displayName, type)
        {
            Authorization = authorization;
            Type = type ?? "blobstorage@v1";
        }

        /// <summary> The authentication definition for blob storage destination. </summary>
        public BlobStorageV1DestinationAuth Authorization { get; set; }
    }
}
