using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class LearningContent : Entity, IParsable {
        /// <summary>Keywords, topics, and other tags associated with the learning content. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AdditionalTags {
            get { return BackingStore?.Get<List<string>?>("additionalTags"); }
            set { BackingStore?.Set("additionalTags", value); }
        }
#nullable restore
#else
        public List<string> AdditionalTags {
            get { return BackingStore?.Get<List<string>>("additionalTags"); }
            set { BackingStore?.Set("additionalTags", value); }
        }
#endif
        /// <summary>The content web URL for the learning content. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentWebUrl {
            get { return BackingStore?.Get<string?>("contentWebUrl"); }
            set { BackingStore?.Set("contentWebUrl", value); }
        }
#nullable restore
#else
        public string ContentWebUrl {
            get { return BackingStore?.Get<string>("contentWebUrl"); }
            set { BackingStore?.Set("contentWebUrl", value); }
        }
#endif
        /// <summary>The authors, creators, or contributors of the learning content. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Contributors {
            get { return BackingStore?.Get<List<string>?>("contributors"); }
            set { BackingStore?.Set("contributors", value); }
        }
#nullable restore
#else
        public List<string> Contributors {
            get { return BackingStore?.Get<List<string>>("contributors"); }
            set { BackingStore?.Set("contributors", value); }
        }
#endif
        /// <summary>The date and time when the learning content was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description or summary for the learning content. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The duration of the learning content in seconds. The value is represented in ISO 8601 format for durations. Optional.</summary>
        public TimeSpan? Duration {
            get { return BackingStore?.Get<TimeSpan?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
        /// <summary>Unique external content ID for the learning content. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId {
            get { return BackingStore?.Get<string?>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#nullable restore
#else
        public string ExternalId {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#endif
        /// <summary>The format of the learning content. For example, Course, Video, Book, Book Summary, Audiobook Summary. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Format {
            get { return BackingStore?.Get<string?>("format"); }
            set { BackingStore?.Set("format", value); }
        }
#nullable restore
#else
        public string Format {
            get { return BackingStore?.Get<string>("format"); }
            set { BackingStore?.Set("format", value); }
        }
#endif
        /// <summary>Indicates whether the content is active or not. Inactive content doesn&apos;t show up in the UI. The default value is true. Optional.</summary>
        public bool? IsActive {
            get { return BackingStore?.Get<bool?>("isActive"); }
            set { BackingStore?.Set("isActive", value); }
        }
        /// <summary>Indicates whether the learning content requires the user to sign-in on the learning provider platform or not. The default value is false. Optional.</summary>
        public bool? IsPremium {
            get { return BackingStore?.Get<bool?>("isPremium"); }
            set { BackingStore?.Set("isPremium", value); }
        }
        /// <summary>Indicates whether the learning content is searchable or not. The default value is true. Optional.</summary>
        public bool? IsSearchable {
            get { return BackingStore?.Get<bool?>("isSearchable"); }
            set { BackingStore?.Set("isSearchable", value); }
        }
        /// <summary>The language of the learning content, for example, en-us or fr-fr. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageTag {
            get { return BackingStore?.Get<string?>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#nullable restore
#else
        public string LanguageTag {
            get { return BackingStore?.Get<string>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#endif
        /// <summary>The date and time when the learning content was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The number of pages of the learning content, for example, 9. Optional.</summary>
        public int? NumberOfPages {
            get { return BackingStore?.Get<int?>("numberOfPages"); }
            set { BackingStore?.Set("numberOfPages", value); }
        }
        /// <summary>The skills tags associated with the learning content. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SkillTags {
            get { return BackingStore?.Get<List<string>?>("skillTags"); }
            set { BackingStore?.Set("skillTags", value); }
        }
#nullable restore
#else
        public List<string> SkillTags {
            get { return BackingStore?.Get<List<string>>("skillTags"); }
            set { BackingStore?.Set("skillTags", value); }
        }
#endif
        /// <summary>The source name of the learning content, such as LinkedIn Learning or Coursera. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceName {
            get { return BackingStore?.Get<string?>("sourceName"); }
            set { BackingStore?.Set("sourceName", value); }
        }
#nullable restore
#else
        public string SourceName {
            get { return BackingStore?.Get<string>("sourceName"); }
            set { BackingStore?.Set("sourceName", value); }
        }
#endif
        /// <summary>The URL of learning content thumbnail image. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbnailWebUrl {
            get { return BackingStore?.Get<string?>("thumbnailWebUrl"); }
            set { BackingStore?.Set("thumbnailWebUrl", value); }
        }
#nullable restore
#else
        public string ThumbnailWebUrl {
            get { return BackingStore?.Get<string>("thumbnailWebUrl"); }
            set { BackingStore?.Set("thumbnailWebUrl", value); }
        }
#endif
        /// <summary>The title of the learning content. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new LearningContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LearningContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"additionalTags", n => { AdditionalTags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"contentWebUrl", n => { ContentWebUrl = n.GetStringValue(); } },
                {"contributors", n => { Contributors = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"duration", n => { Duration = n.GetTimeSpanValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"format", n => { Format = n.GetStringValue(); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"isPremium", n => { IsPremium = n.GetBoolValue(); } },
                {"isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                {"languageTag", n => { LanguageTag = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"numberOfPages", n => { NumberOfPages = n.GetIntValue(); } },
                {"skillTags", n => { SkillTags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sourceName", n => { SourceName = n.GetStringValue(); } },
                {"thumbnailWebUrl", n => { ThumbnailWebUrl = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("additionalTags", AdditionalTags);
            writer.WriteStringValue("contentWebUrl", ContentWebUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("contributors", Contributors);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteTimeSpanValue("duration", Duration);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("format", Format);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteBoolValue("isPremium", IsPremium);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("numberOfPages", NumberOfPages);
            writer.WriteCollectionOfPrimitiveValues<string>("skillTags", SkillTags);
            writer.WriteStringValue("sourceName", SourceName);
            writer.WriteStringValue("thumbnailWebUrl", ThumbnailWebUrl);
            writer.WriteStringValue("title", Title);
        }
    }
}