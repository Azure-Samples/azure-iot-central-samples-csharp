// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The trusted platform module definition. </summary>
    public partial class Tpm
    {
        /// <summary> Initializes a new instance of Tpm. </summary>
        /// <param name="endorsementKey"> The TPM endorsement key for this credential. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endorsementKey"/> is null. </exception>
        public Tpm(string endorsementKey)
        {
            Argument.AssertNotNull(endorsementKey, nameof(endorsementKey));

            EndorsementKey = endorsementKey;
        }

        /// <summary> The TPM endorsement key for this credential. </summary>
        public string EndorsementKey { get; set; }
    }
}
