// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> Configuration specifying options for an image tile. </summary>
    public partial class DataExplorerTileConfiguration : TileConfiguration
    {
        /// <summary> Initializes a new instance of DataExplorerTileConfiguration. </summary>
        /// <param name="queryRange"> The query range configuration of the chart. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queryRange"/> is null. </exception>
        public DataExplorerTileConfiguration(TimeQueryRangeConfiguration queryRange)
        {
            Argument.AssertNotNull(queryRange, nameof(queryRange));

            QueryRange = queryRange;
            Type = "dataExplorer";
        }

        /// <summary> Initializes a new instance of DataExplorerTileConfiguration. </summary>
        /// <param name="type"> The type of widget the tile renders. </param>
        /// <param name="queryRange"> The query range configuration of the chart. </param>
        /// <param name="query"> The id of the Data Explorer query to show in the tile. </param>
        internal DataExplorerTileConfiguration(string type, TimeQueryRangeConfiguration queryRange, string query) : base(type)
        {
            QueryRange = queryRange;
            Query = query;
            Type = type ?? "dataExplorer";
        }

        /// <summary> The query range configuration of the chart. </summary>
        public TimeQueryRangeConfiguration QueryRange { get; set; }
        /// <summary> The id of the Data Explorer query to show in the tile. </summary>
        public string Query { get; set; }
    }
}
