// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.Azure.IoTCentral.Preview.Models;

namespace Microsoft.Azure.IoTCentral.Preview
{
    internal partial class DeviceGroupsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _subdomain;
        private readonly string _baseDomain;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of DeviceGroupsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subdomain"> The application subdomain. </param>
        /// <param name="baseDomain"> The base domain for all Azure IoT Central service requests. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="subdomain"/>, <paramref name="baseDomain"/> or <paramref name="apiVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subdomain"/> is an empty string, and was expected to be non-empty. </exception>
        public DeviceGroupsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subdomain, string baseDomain = "azureiotcentral.com", string apiVersion = "2022-10-31-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _subdomain = subdomain ?? throw new ArgumentNullException(nameof(subdomain));
            _baseDomain = baseDomain ?? throw new ArgumentNullException(nameof(baseDomain));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateListRequest(string filter, int? maxpagesize, string orderby)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_subdomain, true);
            uri.AppendRaw(".", false);
            uri.AppendRaw(_baseDomain, false);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/deviceGroups", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("filter", filter, true);
            }
            if (maxpagesize != null)
            {
                uri.AppendQuery("maxpagesize", maxpagesize.Value, true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("orderby", orderby, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get the list of device groups in an application. </summary>
        /// <param name="filter"> An expression on the resource type that selects the resources to be returned. </param>
        /// <param name="maxpagesize"> The maximum number of resources to return from one response. </param>
        /// <param name="orderby"> An expression that specify the order of the returned resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DeviceGroupCollection>> ListAsync(string filter = null, int? maxpagesize = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(filter, maxpagesize, orderby);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroupCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DeviceGroupCollection.DeserializeDeviceGroupCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the list of device groups in an application. </summary>
        /// <param name="filter"> An expression on the resource type that selects the resources to be returned. </param>
        /// <param name="maxpagesize"> The maximum number of resources to return from one response. </param>
        /// <param name="orderby"> An expression that specify the order of the returned resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DeviceGroupCollection> List(string filter = null, int? maxpagesize = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(filter, maxpagesize, orderby);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroupCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DeviceGroupCollection.DeserializeDeviceGroupCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string deviceGroupId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_subdomain, true);
            uri.AppendRaw(".", false);
            uri.AppendRaw(_baseDomain, false);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/deviceGroups/", false);
            uri.AppendPath(deviceGroupId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get the device group by ID. </summary>
        /// <param name="deviceGroupId"> Unique ID for the device group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupId"/> is null. </exception>
        public async Task<Response<DeviceGroup>> GetAsync(string deviceGroupId, CancellationToken cancellationToken = default)
        {
            if (deviceGroupId == null)
            {
                throw new ArgumentNullException(nameof(deviceGroupId));
            }

            using var message = CreateGetRequest(deviceGroupId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroup value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DeviceGroup.DeserializeDeviceGroup(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the device group by ID. </summary>
        /// <param name="deviceGroupId"> Unique ID for the device group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupId"/> is null. </exception>
        public Response<DeviceGroup> Get(string deviceGroupId, CancellationToken cancellationToken = default)
        {
            if (deviceGroupId == null)
            {
                throw new ArgumentNullException(nameof(deviceGroupId));
            }

            using var message = CreateGetRequest(deviceGroupId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroup value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DeviceGroup.DeserializeDeviceGroup(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string deviceGroupId, DeviceGroup body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_subdomain, true);
            uri.AppendRaw(".", false);
            uri.AppendRaw(_baseDomain, false);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/deviceGroups/", false);
            uri.AppendPath(deviceGroupId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Create or update a device group. </summary>
        /// <param name="deviceGroupId"> Unique ID for the device group. </param>
        /// <param name="body"> Device group body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupId"/> or <paramref name="body"/> is null. </exception>
        /// <remarks> Create or update a device group. </remarks>
        public async Task<Response<DeviceGroup>> CreateAsync(string deviceGroupId, DeviceGroup body, CancellationToken cancellationToken = default)
        {
            if (deviceGroupId == null)
            {
                throw new ArgumentNullException(nameof(deviceGroupId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateCreateRequest(deviceGroupId, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroup value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DeviceGroup.DeserializeDeviceGroup(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create or update a device group. </summary>
        /// <param name="deviceGroupId"> Unique ID for the device group. </param>
        /// <param name="body"> Device group body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupId"/> or <paramref name="body"/> is null. </exception>
        /// <remarks> Create or update a device group. </remarks>
        public Response<DeviceGroup> Create(string deviceGroupId, DeviceGroup body, CancellationToken cancellationToken = default)
        {
            if (deviceGroupId == null)
            {
                throw new ArgumentNullException(nameof(deviceGroupId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateCreateRequest(deviceGroupId, body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroup value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DeviceGroup.DeserializeDeviceGroup(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string deviceGroupId, object body, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_subdomain, true);
            uri.AppendRaw(".", false);
            uri.AppendRaw(_baseDomain, false);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/deviceGroups/", false);
            uri.AppendPath(deviceGroupId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body);
            request.Content = content;
            return message;
        }

        /// <summary> Update a device group via patch. </summary>
        /// <param name="deviceGroupId"> Unique ID for the device group. </param>
        /// <param name="body"> Device group patch body. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupId"/> or <paramref name="body"/> is null. </exception>
        /// <remarks> Update an existing device group by ID. </remarks>
        public async Task<Response<DeviceGroup>> UpdateAsync(string deviceGroupId, object body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (deviceGroupId == null)
            {
                throw new ArgumentNullException(nameof(deviceGroupId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateUpdateRequest(deviceGroupId, body, ifMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroup value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DeviceGroup.DeserializeDeviceGroup(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Update a device group via patch. </summary>
        /// <param name="deviceGroupId"> Unique ID for the device group. </param>
        /// <param name="body"> Device group patch body. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupId"/> or <paramref name="body"/> is null. </exception>
        /// <remarks> Update an existing device group by ID. </remarks>
        public Response<DeviceGroup> Update(string deviceGroupId, object body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (deviceGroupId == null)
            {
                throw new ArgumentNullException(nameof(deviceGroupId));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var message = CreateUpdateRequest(deviceGroupId, body, ifMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroup value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DeviceGroup.DeserializeDeviceGroup(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRemoveRequest(string deviceGroupId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_subdomain, true);
            uri.AppendRaw(".", false);
            uri.AppendRaw(_baseDomain, false);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/deviceGroups/", false);
            uri.AppendPath(deviceGroupId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete a device group. </summary>
        /// <param name="deviceGroupId"> Unique ID for the device group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupId"/> is null. </exception>
        public async Task<Response> RemoveAsync(string deviceGroupId, CancellationToken cancellationToken = default)
        {
            if (deviceGroupId == null)
            {
                throw new ArgumentNullException(nameof(deviceGroupId));
            }

            using var message = CreateRemoveRequest(deviceGroupId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete a device group. </summary>
        /// <param name="deviceGroupId"> Unique ID for the device group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupId"/> is null. </exception>
        public Response Remove(string deviceGroupId, CancellationToken cancellationToken = default)
        {
            if (deviceGroupId == null)
            {
                throw new ArgumentNullException(nameof(deviceGroupId));
            }

            using var message = CreateRemoveRequest(deviceGroupId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetDevicesRequest(string deviceGroupId, int? maxpagesize)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_subdomain, true);
            uri.AppendRaw(".", false);
            uri.AppendRaw(_baseDomain, false);
            uri.AppendRaw("/api", false);
            uri.AppendPath("/deviceGroups/", false);
            uri.AppendPath(deviceGroupId, true);
            uri.AppendPath("/devices", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (maxpagesize != null)
            {
                uri.AppendQuery("maxpagesize", maxpagesize.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get the devices of a device group. </summary>
        /// <param name="deviceGroupId"> Unique ID for the device group. </param>
        /// <param name="maxpagesize"> The maximum number of resources to return from one response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupId"/> is null. </exception>
        /// <remarks> Get the list of devices by device group ID. </remarks>
        public async Task<Response<DeviceGroupDeviceCollection>> GetDevicesAsync(string deviceGroupId, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            if (deviceGroupId == null)
            {
                throw new ArgumentNullException(nameof(deviceGroupId));
            }

            using var message = CreateGetDevicesRequest(deviceGroupId, maxpagesize);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroupDeviceCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DeviceGroupDeviceCollection.DeserializeDeviceGroupDeviceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the devices of a device group. </summary>
        /// <param name="deviceGroupId"> Unique ID for the device group. </param>
        /// <param name="maxpagesize"> The maximum number of resources to return from one response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceGroupId"/> is null. </exception>
        /// <remarks> Get the list of devices by device group ID. </remarks>
        public Response<DeviceGroupDeviceCollection> GetDevices(string deviceGroupId, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            if (deviceGroupId == null)
            {
                throw new ArgumentNullException(nameof(deviceGroupId));
            }

            using var message = CreateGetDevicesRequest(deviceGroupId, maxpagesize);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroupDeviceCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DeviceGroupDeviceCollection.DeserializeDeviceGroupDeviceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string filter, int? maxpagesize, string orderby)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_subdomain, true);
            uri.AppendRaw(".", false);
            uri.AppendRaw(_baseDomain, false);
            uri.AppendRaw("/api", false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get the list of device groups in an application. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="filter"> An expression on the resource type that selects the resources to be returned. </param>
        /// <param name="maxpagesize"> The maximum number of resources to return from one response. </param>
        /// <param name="orderby"> An expression that specify the order of the returned resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<DeviceGroupCollection>> ListNextPageAsync(string nextLink, string filter = null, int? maxpagesize = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink, filter, maxpagesize, orderby);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroupCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DeviceGroupCollection.DeserializeDeviceGroupCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the list of device groups in an application. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="filter"> An expression on the resource type that selects the resources to be returned. </param>
        /// <param name="maxpagesize"> The maximum number of resources to return from one response. </param>
        /// <param name="orderby"> An expression that specify the order of the returned resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<DeviceGroupCollection> ListNextPage(string nextLink, string filter = null, int? maxpagesize = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink, filter, maxpagesize, orderby);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroupCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DeviceGroupCollection.DeserializeDeviceGroupCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetDevicesNextPageRequest(string nextLink, string deviceGroupId, int? maxpagesize)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_subdomain, true);
            uri.AppendRaw(".", false);
            uri.AppendRaw(_baseDomain, false);
            uri.AppendRaw("/api", false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get the devices of a device group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="deviceGroupId"> Unique ID for the device group. </param>
        /// <param name="maxpagesize"> The maximum number of resources to return from one response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="deviceGroupId"/> is null. </exception>
        /// <remarks> Get the list of devices by device group ID. </remarks>
        public async Task<Response<DeviceGroupDeviceCollection>> GetDevicesNextPageAsync(string nextLink, string deviceGroupId, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (deviceGroupId == null)
            {
                throw new ArgumentNullException(nameof(deviceGroupId));
            }

            using var message = CreateGetDevicesNextPageRequest(nextLink, deviceGroupId, maxpagesize);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroupDeviceCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DeviceGroupDeviceCollection.DeserializeDeviceGroupDeviceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the devices of a device group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="deviceGroupId"> Unique ID for the device group. </param>
        /// <param name="maxpagesize"> The maximum number of resources to return from one response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="deviceGroupId"/> is null. </exception>
        /// <remarks> Get the list of devices by device group ID. </remarks>
        public Response<DeviceGroupDeviceCollection> GetDevicesNextPage(string nextLink, string deviceGroupId, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (deviceGroupId == null)
            {
                throw new ArgumentNullException(nameof(deviceGroupId));
            }

            using var message = CreateGetDevicesNextPageRequest(nextLink, deviceGroupId, maxpagesize);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DeviceGroupDeviceCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DeviceGroupDeviceCollection.DeserializeDeviceGroupDeviceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
