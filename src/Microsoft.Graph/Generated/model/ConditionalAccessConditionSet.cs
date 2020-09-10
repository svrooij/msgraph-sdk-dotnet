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
    /// The type ConditionalAccessConditionSet.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ConditionalAccessConditionSet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalAccessConditionSet"/> class.
        /// </summary>
        public ConditionalAccessConditionSet()
        {
            this.ODataType = "microsoft.graph.conditionalAccessConditionSet";
        }

        /// <summary>
        /// Gets or sets applications.
        /// Applications and user actions included in and excluded from the policy. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applications", Required = Newtonsoft.Json.Required.Default)]
        public ConditionalAccessApplications Applications { get; set; }
    
        /// <summary>
        /// Gets or sets clientAppTypes.
        /// Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientAppTypes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ConditionalAccessClientApp> ClientAppTypes { get; set; }
    
        /// <summary>
        /// Gets or sets locations.
        /// Locations included in and excluded from the policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locations", Required = Newtonsoft.Json.Required.Default)]
        public ConditionalAccessLocations Locations { get; set; }
    
        /// <summary>
        /// Gets or sets platforms.
        /// Platforms included in and excluded from the policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "platforms", Required = Newtonsoft.Json.Required.Default)]
        public ConditionalAccessPlatforms Platforms { get; set; }
    
        /// <summary>
        /// Gets or sets signInRiskLevels.
        /// Risk levels included in the policy. Possible values are: low, medium, high, none.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signInRiskLevels", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<RiskLevel> SignInRiskLevels { get; set; }
    
        /// <summary>
        /// Gets or sets users.
        /// Users, groups, and roles included in and excluded from the policy. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "users", Required = Newtonsoft.Json.Required.Default)]
        public ConditionalAccessUsers Users { get; set; }
    
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
