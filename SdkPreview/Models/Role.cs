// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The role definition. </summary>
    public partial class Role
    {
        /// <summary> Initializes a new instance of Role. </summary>
        internal Role()
        {
        }

        /// <summary> Initializes a new instance of Role. </summary>
        /// <param name="id"> Unique ID of the role. </param>
        /// <param name="displayName"> Display name of the role. </param>
        internal Role(string id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }

        /// <summary> Unique ID of the role. </summary>
        public string Id { get; }
        /// <summary> Display name of the role. </summary>
        public string DisplayName { get; }
    }
}