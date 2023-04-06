using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Singleton entity which is used to specify IE mode site metadata
    /// </summary>
    public class BrowserSite : Entity, IParsable {
        /// <summary>Boolean attribute that controls the behavior of redirected sites</summary>
        public bool? AllowRedirect {
            get { return BackingStore?.Get<bool?>("allowRedirect"); }
            set { BackingStore?.Set("allowRedirect", value); }
        }
        /// <summary>The comment for the site</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment {
            get { return BackingStore?.Get<string?>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#nullable restore
#else
        public string Comment {
            get { return BackingStore?.Get<string>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#endif
        /// <summary>The compatibilityMode property</summary>
        public BrowserSiteCompatibilityMode? CompatibilityMode {
            get { return BackingStore?.Get<BrowserSiteCompatibilityMode?>("compatibilityMode"); }
            set { BackingStore?.Set("compatibilityMode", value); }
        }
        /// <summary>The datetime that the site is created</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The datetime that the admin deleted the site</summary>
        public DateTimeOffset? DeletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deletedDateTime"); }
            set { BackingStore?.Set("deletedDateTime", value); }
        }
        /// <summary>The collection stores site revision metadata and audit logs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BrowserSiteHistory>? History {
            get { return BackingStore?.Get<List<BrowserSiteHistory>?>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#nullable restore
#else
        public List<BrowserSiteHistory> History {
            get { return BackingStore?.Get<List<BrowserSiteHistory>>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#endif
        /// <summary>The admin who made the last update on the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The datetime that the admin updated the site.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The mergeType property</summary>
        public BrowserSiteMergeType? MergeType {
            get { return BackingStore?.Get<BrowserSiteMergeType?>("mergeType"); }
            set { BackingStore?.Set("mergeType", value); }
        }
        /// <summary>The status property</summary>
        public BrowserSiteStatus? Status {
            get { return BackingStore?.Get<BrowserSiteStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The targetEnvironment property</summary>
        public BrowserSiteTargetEnvironment? TargetEnvironment {
            get { return BackingStore?.Get<BrowserSiteTargetEnvironment?>("targetEnvironment"); }
            set { BackingStore?.Set("targetEnvironment", value); }
        }
        /// <summary>The URL of the site</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BrowserSite CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BrowserSite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowRedirect", n => { AllowRedirect = n.GetBoolValue(); } },
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"compatibilityMode", n => { CompatibilityMode = n.GetEnumValue<BrowserSiteCompatibilityMode>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"history", n => { History = n.GetCollectionOfObjectValues<BrowserSiteHistory>(BrowserSiteHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"mergeType", n => { MergeType = n.GetEnumValue<BrowserSiteMergeType>(); } },
                {"status", n => { Status = n.GetEnumValue<BrowserSiteStatus>(); } },
                {"targetEnvironment", n => { TargetEnvironment = n.GetEnumValue<BrowserSiteTargetEnvironment>(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowRedirect", AllowRedirect);
            writer.WriteStringValue("comment", Comment);
            writer.WriteEnumValue<BrowserSiteCompatibilityMode>("compatibilityMode", CompatibilityMode);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteCollectionOfObjectValues<BrowserSiteHistory>("history", History);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<BrowserSiteMergeType>("mergeType", MergeType);
            writer.WriteEnumValue<BrowserSiteStatus>("status", Status);
            writer.WriteEnumValue<BrowserSiteTargetEnvironment>("targetEnvironment", TargetEnvironment);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}