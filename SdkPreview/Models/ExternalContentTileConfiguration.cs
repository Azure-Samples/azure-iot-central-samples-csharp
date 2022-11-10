// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> Configuration specifying options for an external content tile. </summary>
    public partial class ExternalContentTileConfiguration : TileConfiguration
    {
        /// <summary> Initializes a new instance of ExternalContentTileConfiguration. </summary>
        /// <param name="sourceUrl"> URL of the website to render inside the tile. Must be a valid HTTPS URL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceUrl"/> is null. </exception>
        public ExternalContentTileConfiguration(string sourceUrl)
        {
            Argument.AssertNotNull(sourceUrl, nameof(sourceUrl));

            SourceUrl = sourceUrl;
            Type = "externalContent";
        }

        /// <summary> Initializes a new instance of ExternalContentTileConfiguration. </summary>
        /// <param name="type"> The type of widget the tile renders. </param>
        /// <param name="sourceUrl"> URL of the website to render inside the tile. Must be a valid HTTPS URL. </param>
        internal ExternalContentTileConfiguration(string type, string sourceUrl) : base(type)
        {
            SourceUrl = sourceUrl;
            Type = type ?? "externalContent";
        }

        /// <summary> URL of the website to render inside the tile. Must be a valid HTTPS URL. </summary>
        public string SourceUrl { get; set; }
    }
}