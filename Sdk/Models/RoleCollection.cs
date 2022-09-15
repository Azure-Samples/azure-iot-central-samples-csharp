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
    /// The paged results of roles.
    /// </summary>
    public partial class RoleCollection
    {
        /// <summary>
        /// Initializes a new instance of the RoleCollection class.
        /// </summary>
        public RoleCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleCollection class.
        /// </summary>
        /// <param name="value">The collection of roles.</param>
        /// <param name="nextLink">URL to get the next page of roles.</param>
        public RoleCollection(IList<Role> value, string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the collection of roles.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Role> Value { get; set; }

        /// <summary>
        /// Gets or sets URL to get the next page of roles.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
