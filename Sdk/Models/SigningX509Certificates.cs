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
    using System.Linq;

    /// <summary>
    /// The X509 certificates definition.
    /// </summary>
    public partial class SigningX509Certificates
    {
        /// <summary>
        /// Initializes a new instance of the SigningX509Certificates class.
        /// </summary>
        public SigningX509Certificates()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SigningX509Certificates class.
        /// </summary>
        /// <param name="primary">The primary X.509 certificate for this
        /// credential.</param>
        /// <param name="secondary">The secondary X.509 certificate for this
        /// credential.</param>
        public SigningX509Certificates(SigningX509Certificate primary = default(SigningX509Certificate), SigningX509Certificate secondary = default(SigningX509Certificate))
        {
            Primary = primary;
            Secondary = secondary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the primary X.509 certificate for this credential.
        /// </summary>
        [JsonProperty(PropertyName = "primary")]
        public SigningX509Certificate Primary { get; set; }

        /// <summary>
        /// Gets or sets the secondary X.509 certificate for this credential.
        /// </summary>
        [JsonProperty(PropertyName = "secondary")]
        public SigningX509Certificate Secondary { get; set; }

    }
}
