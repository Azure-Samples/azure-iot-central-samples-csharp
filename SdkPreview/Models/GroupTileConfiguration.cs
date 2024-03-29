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
    /// <summary> Configuration specifying a set of devices to display data for in a tile. </summary>
    public partial class GroupTileConfiguration
    {
        /// <summary> Initializes a new instance of GroupTileConfiguration. </summary>
        /// <param name="group"> The ID of the device group to display. </param>
        /// <param name="devices"> The list of associated devices to display. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="group"/> or <paramref name="devices"/> is null. </exception>
        public GroupTileConfiguration(string group, IEnumerable<string> devices)
        {
            Argument.AssertNotNull(group, nameof(group));
            Argument.AssertNotNull(devices, nameof(devices));

            Group = group;
            Devices = devices.ToList();
        }

        /// <summary> Initializes a new instance of GroupTileConfiguration. </summary>
        /// <param name="group"> The ID of the device group to display. </param>
        /// <param name="devices"> The list of associated devices to display. </param>
        internal GroupTileConfiguration(string group, IList<string> devices)
        {
            Group = group;
            Devices = devices;
        }

        /// <summary> The ID of the device group to display. </summary>
        public string Group { get; set; }
        /// <summary> The list of associated devices to display. </summary>
        public IList<string> Devices { get; }
    }
}
