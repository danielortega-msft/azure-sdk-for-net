// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// Describes an input data source that contains stream data.
    /// Please note <see cref="StreamInputDataSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="GatewayMessageBusStreamInputDataSource"/>, <see cref="IoTHubStreamInputDataSource"/>, <see cref="EventGridStreamInputDataSource"/>, <see cref="EventHubV2StreamInputDataSource"/>, <see cref="EventHubStreamInputDataSource"/>, <see cref="BlobStreamInputDataSource"/> and <see cref="RawStreamInputDataSource"/>.
    /// </summary>
    public partial class StreamInputDataSource
    {
        /// <summary> Initializes a new instance of StreamInputDataSource. </summary>
        public StreamInputDataSource()
        {
        }

        /// <summary> Initializes a new instance of StreamInputDataSource. </summary>
        /// <param name="streamInputDataSourceType"> Indicates the type of input data source containing stream data. Required on PUT (CreateOrReplace) requests. </param>
        internal StreamInputDataSource(string streamInputDataSourceType)
        {
            StreamInputDataSourceType = streamInputDataSourceType;
        }

        /// <summary> Indicates the type of input data source containing stream data. Required on PUT (CreateOrReplace) requests. </summary>
        internal string StreamInputDataSourceType { get; set; }
    }
}
