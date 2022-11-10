// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The device definition. </summary>
    public partial class Device
    {
        /// <summary> Initializes a new instance of Device. </summary>
        public Device()
        {
            Organizations = new ChangeTrackingList<string>();
            Type = new ChangeTrackingList<DeviceType>();
        }

        /// <summary> Initializes a new instance of Device. </summary>
        /// <param name="id"> Unique ID of the device. </param>
        /// <param name="etag"> ETag used to prevent conflict in device updates. </param>
        /// <param name="displayName"> Display name of the device. </param>
        /// <param name="template"> The device template definition for the device. </param>
        /// <param name="enabled"> Whether the device connection to IoT Central has been enabled. </param>
        /// <param name="provisioned"> Whether resources have been allocated for the device. </param>
        /// <param name="simulated"> Whether the device is simulated. </param>
        /// <param name="organizations"> List of organization IDs that the device is a part of, only one organization is supported today, multiple organizations will be supported soon. </param>
        /// <param name="type"> The type of the device. </param>
        /// <param name="deploymentManifest"> The deployment manifest assigned to the device. </param>
        internal Device(string id, string etag, string displayName, string template, bool? enabled, bool? provisioned, bool? simulated, IList<string> organizations, IList<DeviceType> type, DeploymentManifest deploymentManifest)
        {
            Id = id;
            Etag = etag;
            DisplayName = displayName;
            Template = template;
            Enabled = enabled;
            Provisioned = provisioned;
            Simulated = simulated;
            Organizations = organizations;
            Type = type;
            DeploymentManifest = deploymentManifest;
        }

        /// <summary> Unique ID of the device. </summary>
        public string Id { get; }
        /// <summary> ETag used to prevent conflict in device updates. </summary>
        public string Etag { get; set; }
        /// <summary> Display name of the device. </summary>
        public string DisplayName { get; set; }
        /// <summary> The device template definition for the device. </summary>
        public string Template { get; set; }
        /// <summary> Whether the device connection to IoT Central has been enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Whether resources have been allocated for the device. </summary>
        public bool? Provisioned { get; }
        /// <summary> Whether the device is simulated. </summary>
        public bool? Simulated { get; set; }
        /// <summary> List of organization IDs that the device is a part of, only one organization is supported today, multiple organizations will be supported soon. </summary>
        public IList<string> Organizations { get; }
        /// <summary> The type of the device. </summary>
        public IList<DeviceType> Type { get; }
        /// <summary> The deployment manifest assigned to the device. </summary>
        public DeploymentManifest DeploymentManifest { get; set; }
    }
}