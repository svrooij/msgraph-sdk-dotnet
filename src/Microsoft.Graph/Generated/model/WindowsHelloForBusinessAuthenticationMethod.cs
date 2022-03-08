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
    /// The type Windows Hello For Business Authentication Method.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsHelloForBusinessAuthenticationMethod>))]
    public partial class WindowsHelloForBusinessAuthenticationMethod : AuthenticationMethod
    {
    
        ///<summary>
        /// The WindowsHelloForBusinessAuthenticationMethod constructor
        ///</summary>
        public WindowsHelloForBusinessAuthenticationMethod()
        {
            this.ODataType = "microsoft.graph.windowsHelloForBusinessAuthenticationMethod";
        }

        /// <summary>
        /// Gets or sets created date time.
        /// The date and time that this Windows Hello for Business key was registered.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the device on which Windows Hello for Business is registered
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets key strength.
        /// Key strength of this Windows Hello for Business key. Possible values are: normal, weak, unknown.
        /// </summary>
        [JsonPropertyName("keyStrength")]
        public AuthenticationMethodKeyStrength? KeyStrength { get; set; }
    
        /// <summary>
        /// Gets or sets device.
        /// The registered device on which this Windows Hello for Business key resides. Supports $expand. When you get a user's Windows Hello for Business registration information, this property is returned only on a single GET and when you specify ?$expand. For example, GET /users/admin@contoso.com/authentication/windowsHelloForBusinessMethods/_jpuR-TGZtk6aQCLF3BQjA2?$expand=device.
        /// </summary>
        [JsonPropertyName("device")]
        public Device Device { get; set; }
    
    }
}

