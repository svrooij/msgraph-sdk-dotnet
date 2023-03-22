using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ConditionalAccessTemplate : Entity, IParsable {
        /// <summary>The user-friendly name of the template.</summary>
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
        /// <summary>The details property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessPolicyDetail? Details {
            get { return BackingStore?.Get<ConditionalAccessPolicyDetail?>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#nullable restore
#else
        public ConditionalAccessPolicyDetail Details {
            get { return BackingStore?.Get<ConditionalAccessPolicyDetail>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#endif
        /// <summary>The user-friendly name of the template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The scenarios property</summary>
        public TemplateScenarios? Scenarios {
            get { return BackingStore?.Get<TemplateScenarios?>("scenarios"); }
            set { BackingStore?.Set("scenarios", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConditionalAccessTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"details", n => { Details = n.GetObjectValue<ConditionalAccessPolicyDetail>(ConditionalAccessPolicyDetail.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"scenarios", n => { Scenarios = n.GetEnumValue<TemplateScenarios>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<ConditionalAccessPolicyDetail>("details", Details);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<TemplateScenarios>("scenarios", Scenarios);
        }
    }
}