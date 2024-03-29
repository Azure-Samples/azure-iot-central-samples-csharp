// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    internal partial class UserCollection
    {
        internal static UserCollection DeserializeUserCollection(JsonElement element)
        {
            IReadOnlyList<User> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<User> array = new List<User>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(User.DeserializeUser(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new UserCollection(value, nextLink.Value);
        }
    }
}
