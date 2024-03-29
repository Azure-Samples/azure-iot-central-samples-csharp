// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The service bus queue destination definition. </summary>
    public partial class ServiceBusQueueV1Destination : Destination
    {
        /// <summary> Initializes a new instance of ServiceBusQueueV1Destination. </summary>
        /// <param name="displayName"> Display name of the destination. </param>
        /// <param name="authorization"> The authentication definition for service bus queue definition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/> or <paramref name="authorization"/> is null. </exception>
        public ServiceBusQueueV1Destination(string displayName, ServiceBusQueueV1DestinationAuth authorization) : base(displayName)
        {
            Argument.AssertNotNull(displayName, nameof(displayName));
            Argument.AssertNotNull(authorization, nameof(authorization));

            Authorization = authorization;
            Type = "servicebusqueue@v1";
        }

        /// <summary> Initializes a new instance of ServiceBusQueueV1Destination. </summary>
        /// <param name="status"> Indication of the current health and operation of the export or destination. </param>
        /// <param name="errors"> Errors encountered by the export or destination. </param>
        /// <param name="lastExportTime"> The timestamp of the last message that was sent to the export or destination. </param>
        /// <param name="id"> Unique ID of the destination. </param>
        /// <param name="displayName"> Display name of the destination. </param>
        /// <param name="type"> The type of destination configuration. </param>
        /// <param name="authorization"> The authentication definition for service bus queue definition. </param>
        internal ServiceBusQueueV1Destination(string status, IReadOnlyList<DataExportError> errors, DateTimeOffset? lastExportTime, string id, string displayName, string type, ServiceBusQueueV1DestinationAuth authorization) : base(status, errors, lastExportTime, id, displayName, type)
        {
            Authorization = authorization;
            Type = type ?? "servicebusqueue@v1";
        }

        /// <summary> The authentication definition for service bus queue definition. </summary>
        public ServiceBusQueueV1DestinationAuth Authorization { get; set; }
    }
}
