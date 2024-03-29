// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The command job data definition. </summary>
    public partial class CommandJobData : JobData
    {
        /// <summary> Initializes a new instance of CommandJobData. </summary>
        /// <param name="target"> The device template which defines the target capability for the job. </param>
        /// <param name="path"> The path to the target capability within the device template. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="target"/> or <paramref name="path"/> is null. </exception>
        public CommandJobData(string target, string path)
        {
            Argument.AssertNotNull(target, nameof(target));
            Argument.AssertNotNull(path, nameof(path));

            Target = target;
            Path = path;
            Type = "command";
        }

        /// <summary> Initializes a new instance of CommandJobData. </summary>
        /// <param name="type"> Type of the job data. </param>
        /// <param name="target"> The device template which defines the target capability for the job. </param>
        /// <param name="path"> The path to the target capability within the device template. </param>
        /// <param name="value"> The value used to update the target capability, if any. </param>
        internal CommandJobData(string type, string target, string path, object value) : base(type)
        {
            Target = target;
            Path = path;
            Value = value;
            Type = type ?? "command";
        }

        /// <summary> The device template which defines the target capability for the job. </summary>
        public string Target { get; set; }
        /// <summary> The path to the target capability within the device template. </summary>
        public string Path { get; set; }
        /// <summary> The value used to update the target capability, if any. </summary>
        public object Value { get; set; }
    }
}
