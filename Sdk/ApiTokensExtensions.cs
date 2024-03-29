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
    /// Extension methods for ApiTokens.
    /// </summary>
    public static partial class ApiTokensExtensions
    {
            /// <summary>
            /// Get the list of API tokens in an application. The token value will never be
            /// returned for security reasons.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ApiTokenCollection List(this IApiTokens operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of API tokens in an application. The token value will never be
            /// returned for security reasons.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiTokenCollection> ListAsync(this IApiTokens operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get an API token by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tokenId'>
            /// Unique ID for the API token.
            /// </param>
            public static ApiToken Get(this IApiTokens operations, string tokenId)
            {
                return operations.GetAsync(tokenId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an API token by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tokenId'>
            /// Unique ID for the API token.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiToken> GetAsync(this IApiTokens operations, string tokenId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(tokenId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new API token in the application to use in the IoT Central public
            /// API. The token value will be returned in the response, and won't be
            /// returned again in subsequent requests.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tokenId'>
            /// Unique ID for the API token.
            /// </param>
            /// <param name='body'>
            /// API token body.
            /// </param>
            public static ApiToken Create(this IApiTokens operations, string tokenId, ApiToken body)
            {
                return operations.CreateAsync(tokenId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new API token in the application to use in the IoT Central public
            /// API. The token value will be returned in the response, and won't be
            /// returned again in subsequent requests.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tokenId'>
            /// Unique ID for the API token.
            /// </param>
            /// <param name='body'>
            /// API token body.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiToken> CreateAsync(this IApiTokens operations, string tokenId, ApiToken body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(tokenId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an API token.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tokenId'>
            /// Unique ID for the API token.
            /// </param>
            public static ApiTokensRemoveHeaders Remove(this IApiTokens operations, string tokenId)
            {
                return operations.RemoveAsync(tokenId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an API token.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tokenId'>
            /// Unique ID for the API token.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiTokensRemoveHeaders> RemoveAsync(this IApiTokens operations, string tokenId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RemoveWithHttpMessagesAsync(tokenId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

    }
}
