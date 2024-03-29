// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The X509 certificate verification code. </summary>
    public partial class X509VerificationCode
    {
        /// <summary> Initializes a new instance of X509VerificationCode. </summary>
        internal X509VerificationCode()
        {
        }

        /// <summary> Initializes a new instance of X509VerificationCode. </summary>
        /// <param name="verificationCode"> The X509 certificate verification code. </param>
        internal X509VerificationCode(string verificationCode)
        {
            VerificationCode = verificationCode;
        }

        /// <summary> The X509 certificate verification code. </summary>
        public string VerificationCode { get; }
    }
}
