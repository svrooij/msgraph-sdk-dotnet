// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AggregationOption.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AggregationOption>))]
    public partial class AggregationOption
    {

        /// <summary>
        /// Gets or sets bucketDefinition.
        /// Specifies the criteria to compute an aggregation. Optional.
        /// </summary>
        [JsonPropertyName("bucketDefinition")]
        public BucketAggregationDefinition BucketDefinition { get; set; }
    
        /// <summary>
        /// Gets or sets field.
        /// Computes aggregation on the field while the field exists in current entity type. Required.
        /// </summary>
        [JsonPropertyName("field")]
        public string Field { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// The number of searchBucket resources to be returned. This is not required when the range is provided manually in the search request. Optional.
        /// </summary>
        [JsonPropertyName("size")]
        public Int32? Size { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}