// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The date based end definition of job schedule. </summary>
    public partial class DateJobScheduleEnd : JobScheduleEnd
    {
        /// <summary> Initializes a new instance of DateJobScheduleEnd. </summary>
        /// <param name="date"> The date when to end the scheduled job. </param>
        public DateJobScheduleEnd(DateTimeOffset date)
        {
            Date = date;
            Type = "date";
        }

        /// <summary> Initializes a new instance of DateJobScheduleEnd. </summary>
        /// <param name="type"> Type of the job schedule end. </param>
        /// <param name="date"> The date when to end the scheduled job. </param>
        internal DateJobScheduleEnd(string type, DateTimeOffset date) : base(type)
        {
            Date = date;
            Type = type ?? "date";
        }

        /// <summary> The date when to end the scheduled job. </summary>
        public DateTimeOffset Date { get; set; }
    }
}