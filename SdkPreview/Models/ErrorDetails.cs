// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The detail information of the error. </summary>
    internal partial class ErrorDetails
    {
        /// <summary> Initializes a new instance of ErrorDetails. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal ErrorDetails(string code, string message)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
        }

        /// <summary> Initializes a new instance of ErrorDetails. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message details. </param>
        /// <param name="requestId"> Correlation Id for current request. </param>
        /// <param name="time"> The time that error request failed. </param>
        internal ErrorDetails(string code, string message, string requestId, DateTimeOffset? time)
        {
            Code = code;
            Message = message;
            RequestId = requestId;
            Time = time;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message details. </summary>
        public string Message { get; }
        /// <summary> Correlation Id for current request. </summary>
        public string RequestId { get; }
        /// <summary> The time that error request failed. </summary>
        public DateTimeOffset? Time { get; }
    }
}
