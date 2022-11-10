// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The cloud property job data. </summary>
    public partial class CloudPropertyJobData : JobData
    {
        /// <summary> Initializes a new instance of CloudPropertyJobData. </summary>
        /// <param name="target"> The device template which defines the target capability for the job. </param>
        /// <param name="path"> The path to the target capability within the device template. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="target"/> or <paramref name="path"/> is null. </exception>
        public CloudPropertyJobData(string target, string path)
        {
            Argument.AssertNotNull(target, nameof(target));
            Argument.AssertNotNull(path, nameof(path));

            Target = target;
            Path = path;
            Type = "cloudProperty";
        }

        /// <summary> Initializes a new instance of CloudPropertyJobData. </summary>
        /// <param name="type"> Type of the job data. </param>
        /// <param name="target"> The device template which defines the target capability for the job. </param>
        /// <param name="path"> The path to the target capability within the device template. </param>
        /// <param name="value"> The value used to update the target capability, if any. </param>
        internal CloudPropertyJobData(string type, string target, string path, object value) : base(type)
        {
            Target = target;
            Path = path;
            Value = value;
            Type = type ?? "cloudProperty";
        }

        /// <summary> The device template which defines the target capability for the job. </summary>
        public string Target { get; set; }
        /// <summary> The path to the target capability within the device template. </summary>
        public string Path { get; set; }
        /// <summary> The value used to update the target capability, if any. </summary>
        public object Value { get; set; }
    }
}