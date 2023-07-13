using Microsoft.Graph.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.ReviewSets.Item.Queries.Item.MicrosoftGraphSecurityExport {
    public class ExportPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The description property</summary>
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
        /// <summary>The exportOptions property</summary>
        public Microsoft.Graph.Models.Security.ExportOptions? ExportOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.ExportOptions?>("exportOptions"); }
            set { BackingStore?.Set("exportOptions", value); }
        }
        /// <summary>The exportStructure property</summary>
        public ExportFileStructure? ExportStructure {
            get { return BackingStore?.Get<ExportFileStructure?>("exportStructure"); }
            set { BackingStore?.Set("exportStructure", value); }
        }
        /// <summary>The outputName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputName {
            get { return BackingStore?.Get<string?>("outputName"); }
            set { BackingStore?.Set("outputName", value); }
        }
#nullable restore
#else
        public string OutputName {
            get { return BackingStore?.Get<string>("outputName"); }
            set { BackingStore?.Set("outputName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new exportPostRequestBody and sets the default values.
        /// </summary>
        public ExportPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"exportOptions", n => { ExportOptions = n.GetEnumValue<ExportOptions>(); } },
                {"exportStructure", n => { ExportStructure = n.GetEnumValue<ExportFileStructure>(); } },
                {"outputName", n => { OutputName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<ExportOptions>("exportOptions", ExportOptions);
            writer.WriteEnumValue<ExportFileStructure>("exportStructure", ExportStructure);
            writer.WriteStringValue("outputName", OutputName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}