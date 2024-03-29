// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The user definition. </summary>
    public partial class User : Permission
    {
        /// <summary> Initializes a new instance of User. </summary>
        /// <param name="roles"> List of role assignments that specify the permissions to access the application. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roles"/> is null. </exception>
        public User(IEnumerable<RoleAssignment> roles) : base(roles)
        {
            Argument.AssertNotNull(roles, nameof(roles));
        }

        /// <summary> Initializes a new instance of User. </summary>
        /// <param name="roles"> List of role assignments that specify the permissions to access the application. </param>
        /// <param name="id"> Unique ID of the user. </param>
        /// <param name="type"> Type of the user. </param>
        internal User(IList<RoleAssignment> roles, string id, string type) : base(roles)
        {
            Id = id;
            Type = type;
        }

        /// <summary> Unique ID of the user. </summary>
        public string Id { get; }
        /// <summary> Type of the user. </summary>
        internal string Type { get; set; }
    }
}
