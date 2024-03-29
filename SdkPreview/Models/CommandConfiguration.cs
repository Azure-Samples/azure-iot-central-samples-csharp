// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> Configuration specifying options for a command tile. </summary>
    public partial class CommandConfiguration : TileConfiguration
    {
        /// <summary> Initializes a new instance of CommandConfiguration. </summary>
        /// <param name="device"> The device id that the command is associated with. </param>
        /// <param name="command"> The command id to associate the tile to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="device"/> or <paramref name="command"/> is null. </exception>
        public CommandConfiguration(string device, string command)
        {
            Argument.AssertNotNull(device, nameof(device));
            Argument.AssertNotNull(command, nameof(command));

            Device = device;
            Command = command;
            Type = "command";
        }

        /// <summary> Initializes a new instance of CommandConfiguration. </summary>
        /// <param name="type"> The type of widget the tile renders. </param>
        /// <param name="device"> The device id that the command is associated with. </param>
        /// <param name="command"> The command id to associate the tile to. </param>
        internal CommandConfiguration(string type, string device, string command) : base(type)
        {
            Device = device;
            Command = command;
            Type = type ?? "command";
        }

        /// <summary> The device id that the command is associated with. </summary>
        public string Device { get; set; }
        /// <summary> The command id to associate the tile to. </summary>
        public string Command { get; set; }
    }
}
