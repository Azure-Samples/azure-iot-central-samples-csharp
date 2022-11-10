// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The response error definition. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="errorValue"> Error details for current request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errorValue"/> is null. </exception>
        internal Error(ErrorDetails errorValue)
        {
            Argument.AssertNotNull(errorValue, nameof(errorValue));

            ErrorValue = errorValue;
        }

        /// <summary> Error details for current request. </summary>
        public ErrorDetails ErrorValue { get; }
    }
}
