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
    /// The user definition.
    /// </summary>
    public partial class User : Permission
    {
        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        /// <param name="roles">List of role assignments that specify the
        /// permissions to access the application.</param>
        /// <param name="id">Unique ID of the user.</param>
        public User(IList<RoleAssignment> roles, string id = default(string))
            : base(roles)
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unique ID of the user.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}
