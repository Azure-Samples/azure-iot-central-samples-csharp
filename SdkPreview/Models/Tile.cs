// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> Configuration specifying tile object, including the layout, display name and configuration. </summary>
    public partial class Tile
    {
        /// <summary> Initializes a new instance of Tile. </summary>
        /// <param name="displayName"> Display name of the tile. </param>
        /// <param name="configuration"> The configuration for the tile. </param>
        /// <param name="height"> Height of the tile. </param>
        /// <param name="width"> Width of the tile. </param>
        /// <param name="x"> Horizontal position of the tile. </param>
        /// <param name="y"> Vertical position of the tile. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/> or <paramref name="configuration"/> is null. </exception>
        public Tile(string displayName, TileConfiguration configuration, float height, float width, float x, float y)
        {
            Argument.AssertNotNull(displayName, nameof(displayName));
            Argument.AssertNotNull(configuration, nameof(configuration));

            DisplayName = displayName;
            Configuration = configuration;
            Height = height;
            Width = width;
            X = x;
            Y = y;
        }

        /// <summary> Initializes a new instance of Tile. </summary>
        /// <param name="id"> Unique ID of the tile. </param>
        /// <param name="displayName"> Display name of the tile. </param>
        /// <param name="configuration"> The configuration for the tile. </param>
        /// <param name="height"> Height of the tile. </param>
        /// <param name="width"> Width of the tile. </param>
        /// <param name="x"> Horizontal position of the tile. </param>
        /// <param name="y"> Vertical position of the tile. </param>
        internal Tile(string id, string displayName, TileConfiguration configuration, float height, float width, float x, float y)
        {
            Id = id;
            DisplayName = displayName;
            Configuration = configuration;
            Height = height;
            Width = width;
            X = x;
            Y = y;
        }

        /// <summary> Unique ID of the tile. </summary>
        public string Id { get; }
        /// <summary> Display name of the tile. </summary>
        public string DisplayName { get; set; }
        /// <summary> The configuration for the tile. </summary>
        public TileConfiguration Configuration { get; set; }
        /// <summary> Height of the tile. </summary>
        public float Height { get; set; }
        /// <summary> Width of the tile. </summary>
        public float Width { get; set; }
        /// <summary> Horizontal position of the tile. </summary>
        public float X { get; set; }
        /// <summary> Vertical position of the tile. </summary>
        public float Y { get; set; }
    }
}
