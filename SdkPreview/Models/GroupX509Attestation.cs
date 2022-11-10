// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The X509 attestation definition. </summary>
    public partial class GroupX509Attestation : GroupAttestation
    {
        /// <summary> Initializes a new instance of GroupX509Attestation. </summary>
        public GroupX509Attestation()
        {
            Type = "x509";
        }

        /// <summary> Initializes a new instance of GroupX509Attestation. </summary>
        /// <param name="type"> Type of the attestation. </param>
        /// <param name="x509"> The X.509 credentials for this attestation. </param>
        internal GroupX509Attestation(string type, SigningX509 x509) : base(type)
        {
            X509 = x509;
            Type = type ?? "x509";
        }

        /// <summary> The X.509 credentials for this attestation. </summary>
        public SigningX509 X509 { get; set; }
    }
}
