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
    /// The TPM attestation definition.
    /// </summary>
    [Newtonsoft.Json.JsonObject("tpm")]
    public partial class TpmAttestation : Attestation
    {
        /// <summary>
        /// Initializes a new instance of the TpmAttestation class.
        /// </summary>
        public TpmAttestation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TpmAttestation class.
        /// </summary>
        /// <param name="tpm">The TPM credentials for this attestation.</param>
        public TpmAttestation(Tpm tpm)
        {
            Tpm = tpm;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the TPM credentials for this attestation.
        /// </summary>
        [JsonProperty(PropertyName = "tpm")]
        public Tpm Tpm { get; set; }

    }
}
