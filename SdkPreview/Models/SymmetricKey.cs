// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The symmetric key definition. </summary>
    public partial class SymmetricKey
    {
        /// <summary> Initializes a new instance of SymmetricKey. </summary>
        /// <param name="primaryKey"> The primary key for this credential. </param>
        /// <param name="secondaryKey"> The secondary key for this credential. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="primaryKey"/> or <paramref name="secondaryKey"/> is null. </exception>
        public SymmetricKey(string primaryKey, string secondaryKey)
        {
            Argument.AssertNotNull(primaryKey, nameof(primaryKey));
            Argument.AssertNotNull(secondaryKey, nameof(secondaryKey));

            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
        }

        /// <summary> The primary key for this credential. </summary>
        public string PrimaryKey { get; set; }
        /// <summary> The secondary key for this credential. </summary>
        public string SecondaryKey { get; set; }
    }
}