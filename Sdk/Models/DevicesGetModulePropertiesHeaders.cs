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
    /// Defines headers for GetModuleProperties operation.
    /// </summary>
    public partial class DevicesGetModulePropertiesHeaders
    {
        /// <summary>
        /// Initializes a new instance of the DevicesGetModulePropertiesHeaders
        /// class.
        /// </summary>
        public DevicesGetModulePropertiesHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DevicesGetModulePropertiesHeaders
        /// class.
        /// </summary>
        /// <param name="xMsErrorCode">Error code for specific error that
        /// occurred.</param>
        public DevicesGetModulePropertiesHeaders(string xMsErrorCode = default(string))
        {
            XMsErrorCode = xMsErrorCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error code for specific error that occurred.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-error-code")]
        public string XMsErrorCode { get; set; }

    }
}
