// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Unified Role Management Policy Authentication Context Rule.
    /// </summary>
    public partial class UnifiedRoleManagementPolicyAuthenticationContextRule : UnifiedRoleManagementPolicyRule
    {
    
        ///<summary>
        /// The UnifiedRoleManagementPolicyAuthenticationContextRule constructor
        ///</summary>
        public UnifiedRoleManagementPolicyAuthenticationContextRule()
        {
            this.ODataType = "microsoft.graph.unifiedRoleManagementPolicyAuthenticationContextRule";
        }

        /// <summary>
        /// Gets or sets claim value.
        /// Value of the authentication context claim.
        /// </summary>
        [JsonPropertyName("claimValue")]
        public string ClaimValue { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// Indicates if the setting is enabled.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
    }
}
