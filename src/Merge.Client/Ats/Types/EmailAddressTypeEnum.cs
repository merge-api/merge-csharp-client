using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public enum EmailAddressTypeEnum
{
    [EnumMember(Value = "PERSONAL")]
    Personal,

    [EnumMember(Value = "WORK")]
    Work,

    [EnumMember(Value = "OTHER")]
    Other
}
