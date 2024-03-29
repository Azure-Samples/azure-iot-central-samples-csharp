// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IoTCentral
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DeviceGroups.
    /// </summary>
    public static partial class DeviceGroupsExtensions
    {
            /// <summary>
            /// Get the list of device groups in an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DeviceGroupCollection List(this IDeviceGroups operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of device groups in an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeviceGroupCollection> ListAsync(this IDeviceGroups operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the device group by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceGroupId'>
            /// Unique ID for the device group.
            /// </param>
            public static DeviceGroup Get(this IDeviceGroups operations, string deviceGroupId)
            {
                return operations.GetAsync(deviceGroupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the device group by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceGroupId'>
            /// Unique ID for the device group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeviceGroup> GetAsync(this IDeviceGroups operations, string deviceGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(deviceGroupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a device group
            /// </summary>
            /// <remarks>
            /// Create or update a device group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceGroupId'>
            /// Unique ID for the device group.
            /// </param>
            /// <param name='body'>
            /// Device group body.
            /// </param>
            public static DeviceGroup Create(this IDeviceGroups operations, string deviceGroupId, DeviceGroup body)
            {
                return operations.CreateAsync(deviceGroupId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a device group
            /// </summary>
            /// <remarks>
            /// Create or update a device group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceGroupId'>
            /// Unique ID for the device group.
            /// </param>
            /// <param name='body'>
            /// Device group body.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeviceGroup> CreateAsync(this IDeviceGroups operations, string deviceGroupId, DeviceGroup body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(deviceGroupId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a device group via patch
            /// </summary>
            /// <remarks>
            /// Update an existing device group by ID.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceGroupId'>
            /// Unique ID for the device group.
            /// </param>
            /// <param name='body'>
            /// Device group patch body.
            /// </param>
            public static DeviceGroup Update(this IDeviceGroups operations, string deviceGroupId, object body)
            {
                return operations.UpdateAsync(deviceGroupId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a device group via patch
            /// </summary>
            /// <remarks>
            /// Update an existing device group by ID.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceGroupId'>
            /// Unique ID for the device group.
            /// </param>
            /// <param name='body'>
            /// Device group patch body.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeviceGroup> UpdateAsync(this IDeviceGroups operations, string deviceGroupId, object body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(deviceGroupId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a device group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceGroupId'>
            /// Unique ID for the device group.
            /// </param>
            public static DeviceGroupsRemoveHeaders Remove(this IDeviceGroups operations, string deviceGroupId)
            {
                return operations.RemoveAsync(deviceGroupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a device group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceGroupId'>
            /// Unique ID for the device group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeviceGroupsRemoveHeaders> RemoveAsync(this IDeviceGroups operations, string deviceGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RemoveWithHttpMessagesAsync(deviceGroupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Get the devices of a device group
            /// </summary>
            /// <remarks>
            /// Get the list of devices by device group ID.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceGroupId'>
            /// Unique ID for the device group.
            /// </param>
            public static DeviceGroupDeviceCollection GetDevices(this IDeviceGroups operations, string deviceGroupId)
            {
                return operations.GetDevicesAsync(deviceGroupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the devices of a device group
            /// </summary>
            /// <remarks>
            /// Get the list of devices by device group ID.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceGroupId'>
            /// Unique ID for the device group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeviceGroupDeviceCollection> GetDevicesAsync(this IDeviceGroups operations, string deviceGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDevicesWithHttpMessagesAsync(deviceGroupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
