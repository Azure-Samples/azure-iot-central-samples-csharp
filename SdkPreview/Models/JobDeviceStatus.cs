// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The job device status definition. </summary>
    public partial class JobDeviceStatus
    {
        /// <summary> Initializes a new instance of JobDeviceStatus. </summary>
        internal JobDeviceStatus()
        {
        }

        /// <summary> Initializes a new instance of JobDeviceStatus. </summary>
        /// <param name="id"> ID of the device whose job status is being provided. </param>
        /// <param name="status"> Indicates whether the job is starting, running, etc. for the given device. </param>
        internal JobDeviceStatus(string id, string status)
        {
            Id = id;
            Status = status;
        }

        /// <summary> ID of the device whose job status is being provided. </summary>
        public string Id { get; }
        /// <summary> Indicates whether the job is starting, running, etc. for the given device. </summary>
        public string Status { get; }
    }
}
