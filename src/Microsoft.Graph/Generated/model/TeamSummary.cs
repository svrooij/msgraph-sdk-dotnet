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
    /// The type TeamSummary.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamSummary>))]
    public partial class TeamSummary
    {

        /// <summary>
        /// Gets or sets guestsCount.
        /// Count of guests in a team.
        /// </summary>
        [JsonPropertyName("guestsCount")]
        public Int32? GuestsCount { get; set; }
    
        /// <summary>
        /// Gets or sets membersCount.
        /// Count of members in a team.
        /// </summary>
        [JsonPropertyName("membersCount")]
        public Int32? MembersCount { get; set; }
    
        /// <summary>
        /// Gets or sets ownersCount.
        /// Count of owners in a team.
        /// </summary>
        [JsonPropertyName("ownersCount")]
        public Int32? OwnersCount { get; set; }
    
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