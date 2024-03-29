// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The X509 definition. </summary>
    public partial class X509
    {
        /// <summary> Initializes a new instance of X509. </summary>
        public X509()
        {
        }

        /// <summary> Initializes a new instance of X509. </summary>
        /// <param name="clientCertificates"> The X.509 client certificates for this credential. </param>
        internal X509(X509Certificates clientCertificates)
        {
            ClientCertificates = clientCertificates;
        }

        /// <summary> The X.509 client certificates for this credential. </summary>
        public X509Certificates ClientCertificates { get; set; }
    }
}
