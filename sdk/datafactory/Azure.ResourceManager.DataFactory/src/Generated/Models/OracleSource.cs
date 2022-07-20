// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity Oracle source. </summary>
    public partial class OracleSource : CopySource
    {
        /// <summary> Initializes a new instance of OracleSource. </summary>
        public OracleSource()
        {
            CopySourceType = "OracleSource";
        }

        /// <summary> Initializes a new instance of OracleSource. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="oracleReaderQuery"> Oracle reader query. Type: string (or Expression with resultType string). </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="partitionOption"> The partition mechanism that will be used for Oracle read in parallel. Possible values include: &quot;None&quot;, &quot;PhysicalPartitionsOfTable&quot;, &quot;DynamicRange&quot;. </param>
        /// <param name="partitionSettings"> The settings that will be leveraged for Oracle source partitioning. </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal OracleSource(string copySourceType, BinaryData sourceRetryCount, BinaryData sourceRetryWait, BinaryData maxConcurrentConnections, BinaryData disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, BinaryData oracleReaderQuery, BinaryData queryTimeout, BinaryData partitionOption, OraclePartitionSettings partitionSettings, BinaryData additionalColumns) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            OracleReaderQuery = oracleReaderQuery;
            QueryTimeout = queryTimeout;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            AdditionalColumns = additionalColumns;
            CopySourceType = copySourceType ?? "OracleSource";
        }

        /// <summary> Oracle reader query. Type: string (or Expression with resultType string). </summary>
        public BinaryData OracleReaderQuery { get; set; }
        /// <summary> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public BinaryData QueryTimeout { get; set; }
        /// <summary> The partition mechanism that will be used for Oracle read in parallel. Possible values include: &quot;None&quot;, &quot;PhysicalPartitionsOfTable&quot;, &quot;DynamicRange&quot;. </summary>
        public BinaryData PartitionOption { get; set; }
        /// <summary> The settings that will be leveraged for Oracle source partitioning. </summary>
        public OraclePartitionSettings PartitionSettings { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </summary>
        public BinaryData AdditionalColumns { get; set; }
    }
}
