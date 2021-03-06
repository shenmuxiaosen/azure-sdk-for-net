// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Data.Tables.Models
{
    /// <summary> Table Service Properties. </summary>
    public partial class TableServiceProperties
    {
        /// <summary> Initializes a new instance of TableServiceProperties. </summary>
        public TableServiceProperties()
        {
        }

        /// <summary> Initializes a new instance of TableServiceProperties. </summary>
        /// <param name="logging"> Azure Analytics Logging settings. </param>
        /// <param name="hourMetrics"> A summary of request statistics grouped by API in hourly aggregates for tables. </param>
        /// <param name="minuteMetrics"> A summary of request statistics grouped by API in minute aggregates for tables. </param>
        /// <param name="cors"> The set of CORS rules. </param>
        internal TableServiceProperties(LoggingSettings logging, TableMetrics hourMetrics, TableMetrics minuteMetrics, IList<CorsRule> cors)
        {
            Logging = logging;
            HourMetrics = hourMetrics;
            MinuteMetrics = minuteMetrics;
            Cors = cors;
        }

        /// <summary> Azure Analytics Logging settings. </summary>
        public LoggingSettings Logging { get; set; }
        /// <summary> A summary of request statistics grouped by API in hourly aggregates for tables. </summary>
        public TableMetrics HourMetrics { get; set; }
        /// <summary> A summary of request statistics grouped by API in minute aggregates for tables. </summary>
        public TableMetrics MinuteMetrics { get; set; }
        /// <summary> The set of CORS rules. </summary>
        public IList<CorsRule> Cors { get; set; }
    }
}
