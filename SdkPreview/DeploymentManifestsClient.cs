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
    /// <summary> The DeploymentManifests service client. </summary>
    public partial class DeploymentManifestsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DeploymentManifestsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of DeploymentManifestsClient for mocking. </summary>
        protected DeploymentManifestsClient()
        {
        }

        /// <summary> Initializes a new instance of DeploymentManifestsClient. </summary>
        /// <param name="subdomain"> The application subdomain. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="baseDomain"> The base domain for all Azure IoT Central service requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public DeploymentManifestsClient(string subdomain, TokenCredential credential, string baseDomain = "azureiotcentral.com", AzureIoTCentralClientOptions options = null)
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
            RestClient = new DeploymentManifestsRestClient(_clientDiagnostics, _pipeline, subdomain, baseDomain, options.Version);
        }

        /// <summary> Initializes a new instance of DeploymentManifestsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subdomain"> The application subdomain. </param>
        /// <param name="baseDomain"> The base domain for all Azure IoT Central service requests. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="subdomain"/>, <paramref name="baseDomain"/> or <paramref name="apiVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subdomain"/> is an empty string, and was expected to be non-empty. </exception>
        internal DeploymentManifestsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subdomain, string baseDomain = "azureiotcentral.com", string apiVersion = "2022-10-31-preview")
        {
            RestClient = new DeploymentManifestsRestClient(clientDiagnostics, pipeline, subdomain, baseDomain, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get a deployment manifest by ID. </summary>
        /// <param name="deploymentManifestId"> Unique ID for the deployment manifest. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeploymentManifest>> GetAsync(string deploymentManifestId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentManifestsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(deploymentManifestId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a deployment manifest by ID. </summary>
        /// <param name="deploymentManifestId"> Unique ID for the deployment manifest. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeploymentManifest> Get(string deploymentManifestId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentManifestsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(deploymentManifestId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a new deployment manifest. </summary>
        /// <param name="deploymentManifestId"> Unique ID for the deployment manifest. </param>
        /// <param name="body"> deployment manifest body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeploymentManifest>> CreateAsync(string deploymentManifestId, DeploymentManifest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentManifestsClient.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(deploymentManifestId, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a new deployment manifest. </summary>
        /// <param name="deploymentManifestId"> Unique ID for the deployment manifest. </param>
        /// <param name="body"> deployment manifest body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeploymentManifest> Create(string deploymentManifestId, DeploymentManifest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentManifestsClient.Create");
            scope.Start();
            try
            {
                return RestClient.Create(deploymentManifestId, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an existing deployment manifest. </summary>
        /// <param name="deploymentManifestId"> Unique ID for the deployment manifest. </param>
        /// <param name="body"> Deployment manifest patch body. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeploymentManifest>> UpdateAsync(string deploymentManifestId, object body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentManifestsClient.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(deploymentManifestId, body, ifMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an existing deployment manifest. </summary>
        /// <param name="deploymentManifestId"> Unique ID for the deployment manifest. </param>
        /// <param name="body"> Deployment manifest patch body. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeploymentManifest> Update(string deploymentManifestId, object body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentManifestsClient.Update");
            scope.Start();
            try
            {
                return RestClient.Update(deploymentManifestId, body, ifMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a deployment manifest. </summary>
        /// <param name="deploymentManifestId"> Unique ID for the deployment manifest. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RemoveAsync(string deploymentManifestId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentManifestsClient.Remove");
            scope.Start();
            try
            {
                return await RestClient.RemoveAsync(deploymentManifestId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a deployment manifest. </summary>
        /// <param name="deploymentManifestId"> Unique ID for the deployment manifest. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Remove(string deploymentManifestId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentManifestsClient.Remove");
            scope.Start();
            try
            {
                return RestClient.Remove(deploymentManifestId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the list of deployment manifests. </summary>
        /// <param name="maxpagesize"> The maximum number of resources to return from one response. </param>
        /// <param name="filter"> An expression on the resource type that selects the resources to be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DeploymentManifest> ListAsync(int? maxpagesize = null, string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DeploymentManifest>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentManifestsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(maxpagesize, filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeploymentManifest>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentManifestsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, maxpagesize, filter, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Get the list of deployment manifests. </summary>
        /// <param name="maxpagesize"> The maximum number of resources to return from one response. </param>
        /// <param name="filter"> An expression on the resource type that selects the resources to be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DeploymentManifest> List(int? maxpagesize = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Page<DeploymentManifest> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentManifestsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(maxpagesize, filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeploymentManifest> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentManifestsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, maxpagesize, filter, cancellationToken);
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
