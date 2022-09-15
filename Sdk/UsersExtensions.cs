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
    /// Extension methods for Users.
    /// </summary>
    public static partial class UsersExtensions
    {
            /// <summary>
            /// Get the list of users in an application
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static UserCollection List(this IUsers operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of users in an application
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserCollection> ListAsync(this IUsers operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a user by ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// Unique ID for the user.
            /// </param>
            public static User Get(this IUsers operations, string userId)
            {
                return operations.GetAsync(userId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a user by ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// Unique ID for the user.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> GetAsync(this IUsers operations, string userId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(userId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a user in the application
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// Unique ID for the user.
            /// </param>
            /// <param name='body'>
            /// User body.
            /// </param>
            public static User Create(this IUsers operations, string userId, User body)
            {
                return operations.CreateAsync(userId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a user in the application
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// Unique ID for the user.
            /// </param>
            /// <param name='body'>
            /// User body.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> CreateAsync(this IUsers operations, string userId, User body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(userId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a user in the application via patch
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// Unique ID for the user.
            /// </param>
            /// <param name='body'>
            /// User patch body.
            /// </param>
            public static User Update(this IUsers operations, string userId, object body)
            {
                return operations.UpdateAsync(userId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a user in the application via patch
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// Unique ID for the user.
            /// </param>
            /// <param name='body'>
            /// User patch body.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> UpdateAsync(this IUsers operations, string userId, object body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(userId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// Unique ID for the user.
            /// </param>
            public static UsersRemoveHeaders Remove(this IUsers operations, string userId)
            {
                return operations.RemoveAsync(userId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// Unique ID for the user.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UsersRemoveHeaders> RemoveAsync(this IUsers operations, string userId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RemoveWithHttpMessagesAsync(userId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

    }
}