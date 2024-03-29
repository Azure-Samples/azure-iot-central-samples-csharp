// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The device group definition. </summary>
    public partial class DeviceGroup
    {
        /// <summary> Initializes a new instance of DeviceGroup. </summary>
        /// <param name="displayName"> Display name of the device group. </param>
        /// <param name="filter"> Query defining which devices should be in this group, [Query Language Reference](https://aka.ms/iotcquery). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/> or <paramref name="filter"/> is null. </exception>
        public DeviceGroup(string displayName, string filter)
        {
            Argument.AssertNotNull(displayName, nameof(displayName));
            Argument.AssertNotNull(filter, nameof(filter));

            DisplayName = displayName;
            Filter = filter;
            Organizations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DeviceGroup. </summary>
        /// <param name="id"> Unique ID of the device group. </param>
        /// <param name="displayName"> Display name of the device group. </param>
        /// <param name="filter"> Query defining which devices should be in this group, [Query Language Reference](https://aka.ms/iotcquery). </param>
        /// <param name="description"> Short summary of device group. </param>
        /// <param name="etag"> ETag used to prevent conflict in device group updates. </param>
        /// <param name="organizations"> List of organization IDs of the device group, only one organization is supported today, multiple organizations will be supported soon. </param>
        internal DeviceGroup(string id, string displayName, string filter, string description, string etag, IList<string> organizations)
        {
            Id = id;
            DisplayName = displayName;
            Filter = filter;
            Description = description;
            Etag = etag;
            Organizations = organizations;
        }

        /// <summary> Unique ID of the device group. </summary>
        public string Id { get; }
        /// <summary> Display name of the device group. </summary>
        public string DisplayName { get; set; }
        /// <summary> Query defining which devices should be in this group, [Query Language Reference](https://aka.ms/iotcquery). </summary>
        public string Filter { get; set; }
        /// <summary> Short summary of device group. </summary>
        public string Description { get; set; }
        /// <summary> ETag used to prevent conflict in device group updates. </summary>
        public string Etag { get; set; }
        /// <summary> List of organization IDs of the device group, only one organization is supported today, multiple organizations will be supported soon. </summary>
        public IList<string> Organizations { get; }
    }
}
