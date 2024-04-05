using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum ActivityTypeEnum
{
    [EnumMember(Value = "NOTE")]
    Note,

    [EnumMember(Value = "EMAIL")]
    Email,

    [EnumMember(Value = "OTHER")]
    Other
}
