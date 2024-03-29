// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.Azure.IoTCentral.Preview.Models;

namespace Microsoft.Azure.IoTCentral.Preview
{
    /// <summary> The Users service client. </summary>
    public partial class UsersClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal UsersRestClient RestClient { get; }

        /// <summary> Initializes a new instance of UsersClient for mocking. </summary>
        protected UsersClient()
        {
        }

        /// <summary> Initializes a new instance of UsersClient. </summary>
        /// <param name="subdomain"> The application subdomain. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="baseDomain"> The base domain for all Azure IoT Central service requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public UsersClient(string subdomain, TokenCredential credential, string baseDomain = "azureiotcentral.com", AzureIoTCentralClientOptions options = null)
        {
            if (subdomain == null)
            {
                throw new ArgumentNullException(nameof(subdomain));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            if (baseDomain == null)
            {
                throw new ArgumentNullException(nameof(baseDomain));
            }

            options ??= new AzureIoTCentralClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://apps.azureiotcentral.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new UsersRestClient(_clientDiagnostics, _pipeline, subdomain, baseDomain, options.Version);
        }

        /// <summary> Initializes a new instance of UsersClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subdomain"> The application subdomain. </param>
        /// <param name="baseDomain"> The base domain for all Azure IoT Central service requests. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="subdomain"/>, <paramref name="baseDomain"/> or <paramref name="apiVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subdomain"/> is an empty string, and was expected to be non-empty. </exception>
        internal UsersClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subdomain, string baseDomain = "azureiotcentral.com", string apiVersion = "2022-10-31-preview")
        {
            RestClient = new UsersRestClient(clientDiagnostics, pipeline, subdomain, baseDomain, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get a user by ID. </summary>
        /// <param name="userId"> Unique ID for the user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<User>> GetAsync(string userId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(userId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a user by ID. </summary>
        /// <param name="userId"> Unique ID for the user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<User> Get(string userId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(userId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a user in the application. </summary>
        /// <param name="userId"> Unique ID for the user. </param>
        /// <param name="body"> User body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<User>> CreateAsync(string userId, User body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersClient.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(userId, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a user in the application. </summary>
        /// <param name="userId"> Unique ID for the user. </param>
        /// <param name="body"> User body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<User> Create(string userId, User body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersClient.Create");
            scope.Start();
            try
            {
                return RestClient.Create(userId, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a user in the application via patch. </summary>
        /// <param name="userId"> Unique ID for the user. </param>
        /// <param name="body"> User patch body. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<User>> UpdateAsync(string userId, object body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersClient.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(userId, body, ifMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a user in the application via patch. </summary>
        /// <param name="userId"> Unique ID for the user. </param>
        /// <param name="body"> User patch body. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<User> Update(string userId, object body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersClient.Update");
            scope.Start();
            try
            {
                return RestClient.Update(userId, body, ifMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a user. </summary>
        /// <param name="userId"> Unique ID for the user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RemoveAsync(string userId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersClient.Remove");
            scope.Start();
            try
            {
                return await RestClient.RemoveAsync(userId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a user. </summary>
        /// <param name="userId"> Unique ID for the user. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Remove(string userId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("UsersClient.Remove");
            scope.Start();
            try
            {
                return RestClient.Remove(userId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the list of users in an application. </summary>
        /// <param name="maxpagesize"> The maximum number of resources to return from one response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<User> ListAsync(int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<User>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(maxpagesize, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<User>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, maxpagesize, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get the list of users in an application. </summary>
        /// <param name="maxpagesize"> The maximum number of resources to return from one response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<User> List(int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            Page<User> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(maxpagesize, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<User> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("UsersClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, maxpagesize, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
