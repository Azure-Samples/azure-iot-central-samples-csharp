// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The organization definition. </summary>
    public partial class Organization
    {
        /// <summary> Initializes a new instance of Organization. </summary>
        public Organization()
        {
        }

        /// <summary> Initializes a new instance of Organization. </summary>
        /// <param name="id"> Unique ID of the organization. </param>
        /// <param name="displayName"> Display name of the organization. </param>
        /// <param name="parent"> ID of the parent of the organization. </param>
        internal Organization(string id, string displayName, string parent)
        {
            Id = id;
            DisplayName = displayName;
            Parent = parent;
        }

        /// <summary> Unique ID of the organization. </summary>
        public string Id { get; }
        /// <summary> Display name of the organization. </summary>
        public string DisplayName { get; set; }
        /// <summary> ID of the parent of the organization. </summary>
        public string Parent { get; set; }
    }
}
