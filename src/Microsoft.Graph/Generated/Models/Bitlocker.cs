using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Bitlocker : Entity, IParsable {
        /// <summary>The recovery keys associated with the bitlocker entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BitlockerRecoveryKey>? RecoveryKeys {
            get { return BackingStore?.Get<List<BitlockerRecoveryKey>?>("recoveryKeys"); }
            set { BackingStore?.Set("recoveryKeys", value); }
        }
#nullable restore
#else
        public List<BitlockerRecoveryKey> RecoveryKeys {
            get { return BackingStore?.Get<List<BitlockerRecoveryKey>>("recoveryKeys"); }
            set { BackingStore?.Set("recoveryKeys", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Bitlocker CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Bitlocker();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"recoveryKeys", n => { RecoveryKeys = n.GetCollectionOfObjectValues<BitlockerRecoveryKey>(BitlockerRecoveryKey.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<BitlockerRecoveryKey>("recoveryKeys", RecoveryKeys);
        }
    }
}