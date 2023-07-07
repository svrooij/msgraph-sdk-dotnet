using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum AssignmentType {
        [EnumMember(Value = "required")]
        Required,
        [EnumMember(Value = "recommended")]
        Recommended,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}