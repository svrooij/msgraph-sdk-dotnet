using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// The user experience analytics insight is the recomendation to improve the user experience analytics score.
    /// </summary>
    public class UserExperienceAnalyticsInsight : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The unique identifier of the user experience analytics insight.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InsightId {
            get { return BackingStore?.Get<string?>("insightId"); }
            set { BackingStore?.Set("insightId", value); }
        }
#nullable restore
#else
        public string InsightId {
            get { return BackingStore?.Get<string>("insightId"); }
            set { BackingStore?.Set("insightId", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Indicates severity of insights. Possible values are: None, Informational, Warning, Error.</summary>
        public UserExperienceAnalyticsInsightSeverity? Severity {
            get { return BackingStore?.Get<UserExperienceAnalyticsInsightSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The unique identifier of the user experience analytics metric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserExperienceAnalyticsMetricId {
            get { return BackingStore?.Get<string?>("userExperienceAnalyticsMetricId"); }
            set { BackingStore?.Set("userExperienceAnalyticsMetricId", value); }
        }
#nullable restore
#else
        public string UserExperienceAnalyticsMetricId {
            get { return BackingStore?.Get<string>("userExperienceAnalyticsMetricId"); }
            set { BackingStore?.Set("userExperienceAnalyticsMetricId", value); }
        }
#endif
        /// <summary>The value of the user experience analytics insight.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsInsightValue>? Values {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsInsightValue>?>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#nullable restore
#else
        public List<UserExperienceAnalyticsInsightValue> Values {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsInsightValue>>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsInsight and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsInsight() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserExperienceAnalyticsInsight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"insightId", n => { InsightId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"severity", n => { Severity = n.GetEnumValue<UserExperienceAnalyticsInsightSeverity>(); } },
                {"userExperienceAnalyticsMetricId", n => { UserExperienceAnalyticsMetricId = n.GetStringValue(); } },
                {"values", n => { Values = n.GetCollectionOfObjectValues<UserExperienceAnalyticsInsightValue>(UserExperienceAnalyticsInsightValue.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("insightId", InsightId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<UserExperienceAnalyticsInsightSeverity>("severity", Severity);
            writer.WriteStringValue("userExperienceAnalyticsMetricId", UserExperienceAnalyticsMetricId);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsInsightValue>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}