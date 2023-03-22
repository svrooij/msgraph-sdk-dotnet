using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.If {
    public class IfPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The logicalTest property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? LogicalTest {
            get { return BackingStore?.Get<Json?>("logicalTest"); }
            set { BackingStore?.Set("logicalTest", value); }
        }
#nullable restore
#else
        public Json LogicalTest {
            get { return BackingStore?.Get<Json>("logicalTest"); }
            set { BackingStore?.Set("logicalTest", value); }
        }
#endif
        /// <summary>The valueIfFalse property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? ValueIfFalse {
            get { return BackingStore?.Get<Json?>("valueIfFalse"); }
            set { BackingStore?.Set("valueIfFalse", value); }
        }
#nullable restore
#else
        public Json ValueIfFalse {
            get { return BackingStore?.Get<Json>("valueIfFalse"); }
            set { BackingStore?.Set("valueIfFalse", value); }
        }
#endif
        /// <summary>The valueIfTrue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? ValueIfTrue {
            get { return BackingStore?.Get<Json?>("valueIfTrue"); }
            set { BackingStore?.Set("valueIfTrue", value); }
        }
#nullable restore
#else
        public Json ValueIfTrue {
            get { return BackingStore?.Get<Json>("valueIfTrue"); }
            set { BackingStore?.Set("valueIfTrue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new ifPostRequestBody and sets the default values.
        /// </summary>
        public IfPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IfPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IfPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"logicalTest", n => { LogicalTest = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"valueIfFalse", n => { ValueIfFalse = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"valueIfTrue", n => { ValueIfTrue = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("logicalTest", LogicalTest);
            writer.WriteObjectValue<Json>("valueIfFalse", ValueIfFalse);
            writer.WriteObjectValue<Json>("valueIfTrue", ValueIfTrue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}