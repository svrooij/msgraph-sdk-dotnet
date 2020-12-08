// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Channel.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Channel : Entity
    {
    
		///<summary>
		/// The Channel constructor
		///</summary>
        public Channel()
        {
            this.ODataType = "microsoft.graph.channel";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// Optional textual description for the channel.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Channel name as it will appear to the user in Microsoft Teams.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// The email address for sending messages to the channel. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email", Required = Newtonsoft.Json.Required.Default)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets is favorite by default.
        /// Indicates whether the channel should automatically be marked 'favorite' for all members of the team. Can only be set programmatically with Create team. Default: false.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isFavoriteByDefault", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsFavoriteByDefault { get; set; }
    
        /// <summary>
        /// Gets or sets membership type.
        /// The type of the channel. Can be set during creation and cannot be changed. Possible values are: standard - Channel inherits the list of members of the parent team; private - Channel can have members that are a subset of all the members on the parent team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "membershipType", Required = Newtonsoft.Json.Required.Default)]
        public ChannelMembershipType? MembershipType { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// A hyperlink that will go to the channel in Microsoft Teams. This is the URL that you get when you right-click a channel in Microsoft Teams and select Get link to channel. This URL should be treated as an opaque blob, and not parsed. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webUrl", Required = Newtonsoft.Json.Required.Default)]
        public string WebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets files folder.
        /// Metadata for the location where the channel's files are stored.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "filesFolder", Required = Newtonsoft.Json.Required.Default)]
        public DriveItem FilesFolder { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// A collection of membership records associated with the channel.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "members", Required = Newtonsoft.Json.Required.Default)]
        public IChannelMembersCollectionPage Members { get; set; }
    
        /// <summary>
        /// Gets or sets messages.
        /// A collection of all the messages in the channel. A navigation property. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messages", Required = Newtonsoft.Json.Required.Default)]
        public IChannelMessagesCollectionPage Messages { get; set; }
    
        /// <summary>
        /// Gets or sets tabs.
        /// A collection of all the tabs in the channel. A navigation property.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tabs", Required = Newtonsoft.Json.Required.Default)]
        public IChannelTabsCollectionPage Tabs { get; set; }
    
    }
}

