// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The role assignment definition. </summary>
    public partial class RoleAssignment
    {
        /// <summary> Initializes a new instance of RoleAssignment. </summary>
        /// <param name="role"> ID of the role for this role assignment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="role"/> is null. </exception>
        public RoleAssignment(string role)
        {
            Argument.AssertNotNull(role, nameof(role));

            Role = role;
        }

        /// <summary> Initializes a new instance of RoleAssignment. </summary>
        /// <param name="role"> ID of the role for this role assignment. </param>
        /// <param name="organization"> ID of the organization for this role assignment. </param>
        internal RoleAssignment(string role, string organization)
        {
            Role = role;
            Organization = organization;
        }

        /// <summary> ID of the role for this role assignment. </summary>
        public string Role { get; set; }
        /// <summary> ID of the organization for this role assignment. </summary>
        public string Organization { get; set; }
    }
}