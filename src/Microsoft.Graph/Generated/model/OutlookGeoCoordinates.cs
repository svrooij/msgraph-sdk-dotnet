// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type OutlookGeoCoordinates.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class OutlookGeoCoordinates
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutlookGeoCoordinates"/> class.
        /// </summary>
        public OutlookGeoCoordinates()
        {
            this.ODataType = "microsoft.graph.outlookGeoCoordinates";
        }

        /// <summary>
        /// Gets or sets accuracy.
        /// The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accuracy", Required = Newtonsoft.Json.Required.Default)]
        public double? Accuracy { get; set; }
    
        /// <summary>
        /// Gets or sets altitude.
        /// The altitude of the location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "altitude", Required = Newtonsoft.Json.Required.Default)]
        public double? Altitude { get; set; }
    
        /// <summary>
        /// Gets or sets altitudeAccuracy.
        /// The accuracy of the altitude.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "altitudeAccuracy", Required = Newtonsoft.Json.Required.Default)]
        public double? AltitudeAccuracy { get; set; }
    
        /// <summary>
        /// Gets or sets latitude.
        /// The latitude of the location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "latitude", Required = Newtonsoft.Json.Required.Default)]
        public double? Latitude { get; set; }
    
        /// <summary>
        /// Gets or sets longitude.
        /// The longitude of the location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "longitude", Required = Newtonsoft.Json.Required.Default)]
        public double? Longitude { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
