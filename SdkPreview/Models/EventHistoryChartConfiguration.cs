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
    /// <summary> Configuration specifying options for a event history chart tile. </summary>
    public partial class EventHistoryChartConfiguration : TileConfiguration
    {
        /// <summary> Initializes a new instance of EventHistoryChartConfiguration. </summary>
        /// <param name="queryRange"> The query range configuration of the event history chart. </param>
        /// <param name="group"> The ID of the device group to display. </param>
        /// <param name="devices"> The list of associated devices to display. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queryRange"/>, <paramref name="group"/> or <paramref name="devices"/> is null. </exception>
        public EventHistoryChartConfiguration(TimeQueryRangeConfiguration queryRange, string group, IEnumerable<string> devices)
        {
            Argument.AssertNotNull(queryRange, nameof(queryRange));
            Argument.AssertNotNull(group, nameof(group));
            Argument.AssertNotNull(devices, nameof(devices));

            QueryRange = queryRange;
            Group = group;
            Devices = devices.ToList();
            Capabilities = new ChangeTrackingList<TileCapability>();
            Type = "eventHistoryChart";
        }

        /// <summary> Initializes a new instance of EventHistoryChartConfiguration. </summary>
        /// <param name="type"> The type of widget the tile renders. </param>
        /// <param name="queryRange"> The query range configuration of the event history chart. </param>
        /// <param name="format"> The format configuration of the event history chart. </param>
        /// <param name="group"> The ID of the device group to display. </param>
        /// <param name="devices"> The list of associated devices to display. </param>
        /// <param name="capabilities"></param>
        internal EventHistoryChartConfiguration(string type, TimeQueryRangeConfiguration queryRange, TextFormatConfiguration format, string group, IList<string> devices, IList<TileCapability> capabilities) : base(type)
        {
            QueryRange = queryRange;
            Format = format;
            Group = group;
            Devices = devices;
            Capabilities = capabilities;
            Type = type ?? "eventHistoryChart";
        }

        /// <summary> The query range configuration of the event history chart. </summary>
        public TimeQueryRangeConfiguration QueryRange { get; set; }
        /// <summary> The format configuration of the event history chart. </summary>
        public TextFormatConfiguration Format { get; set; }
        /// <summary> The ID of the device group to display. </summary>
        public string Group { get; set; }
        /// <summary> The list of associated devices to display. </summary>
        public IList<string> Devices { get; }
        /// <summary> Gets the capabilities. </summary>
        public IList<TileCapability> Capabilities { get; }
    }
}