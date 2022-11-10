// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The device command definition. </summary>
    public partial class DeviceCommand
    {
        /// <summary> Initializes a new instance of DeviceCommand. </summary>
        public DeviceCommand()
        {
        }

        /// <summary> Initializes a new instance of DeviceCommand. </summary>
        /// <param name="id"> The request ID of the device command execution. </param>
        /// <param name="connectionTimeout"> Connection timeout in seconds to wait for a disconnected device to come online. Defaults to 0 seconds. </param>
        /// <param name="responseTimeout"> Response timeout in seconds to wait for a command completion on a device. Defaults to 30 seconds. </param>
        /// <param name="request"> The payload for the device command, support any primitive types or object. </param>
        /// <param name="response"> The payload of the device command response, support any primitive types or object. </param>
        /// <param name="responseCode"> The status code of the device command response. </param>
        internal DeviceCommand(string id, int? connectionTimeout, int? responseTimeout, object request, object response, int? responseCode)
        {
            Id = id;
            ConnectionTimeout = connectionTimeout;
            ResponseTimeout = responseTimeout;
            Request = request;
            Response = response;
            ResponseCode = responseCode;
        }

        /// <summary> The request ID of the device command execution. </summary>
        public string Id { get; }
        /// <summary> Connection timeout in seconds to wait for a disconnected device to come online. Defaults to 0 seconds. </summary>
        public int? ConnectionTimeout { get; set; }
        /// <summary> Response timeout in seconds to wait for a command completion on a device. Defaults to 30 seconds. </summary>
        public int? ResponseTimeout { get; set; }
        /// <summary> The payload for the device command, support any primitive types or object. </summary>
        public object Request { get; set; }
        /// <summary> The payload of the device command response, support any primitive types or object. </summary>
        public object Response { get; }
        /// <summary> The status code of the device command response. </summary>
        public int? ResponseCode { get; }
    }
}