// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IoTCentral.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The device group definition.
    /// </summary>
    public partial class DeviceGroup
    {
        /// <summary>
        /// Initializes a new instance of the DeviceGroup class.
        /// </summary>
        public DeviceGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceGroup class.
        /// </summary>
        /// <param name="displayName">Display name of the device group.</param>
        /// <param name="filter">Query defining which devices should be in this
        /// group, [Query Language
        /// Reference](https://aka.ms/iotcquery).</param>
        /// <param name="id">Unique ID of the device group.</param>
        /// <param name="description">Short summary of device group.</param>
        /// <param name="etag">ETag used to prevent conflict in device group
        /// updates.</param>
        /// <param name="organizations">List of organization IDs of the device
        /// group, only one organization is supported today, multiple
        /// organizations will be supported soon.</param>
        public DeviceGroup(string displayName, string filter, string id = default(string), string description = default(string), string etag = default(string), IList<string> organizations = default(IList<string>))
        {
            Id = id;
            DisplayName = displayName;
            Filter = filter;
            Description = description;
            Etag = etag;
            Organizations = organizations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unique ID of the device group.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets display name of the device group.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets query defining which devices should be in this group,
        /// [Query Language Reference](https://aka.ms/iotcquery).
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets short summary of device group.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets eTag used to prevent conflict in device group updates.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets list of organization IDs of the device group, only one
        /// organization is supported today, multiple organizations will be
        /// supported soon.
        /// </summary>
        [JsonProperty(PropertyName = "organizations")]
        public IList<string> Organizations { get; set; }

    }
}
