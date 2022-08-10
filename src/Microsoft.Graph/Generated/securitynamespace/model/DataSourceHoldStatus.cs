// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.SecurityNamespace
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum DataSourceHoldStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DataSourceHoldStatus
    {
    
        /// <summary>
        /// Not Applied
        /// </summary>
        NotApplied = 1,
	
        /// <summary>
        /// Applied
        /// </summary>
        Applied = 2,
	
        /// <summary>
        /// Applying
        /// </summary>
        Applying = 3,
	
        /// <summary>
        /// Removing
        /// </summary>
        Removing = 4,
	
        /// <summary>
        /// Partial
        /// </summary>
        Partial = 5,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 6,
	
    }
}