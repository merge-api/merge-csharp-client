using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum GenderEnum
{
    [EnumMember(Value = "MALE")]
    Male,

    [EnumMember(Value = "FEMALE")]
    Female,

    [EnumMember(Value = "NON-BINARY")]
    NonBinary,

    [EnumMember(Value = "OTHER")]
    Other,

    [EnumMember(Value = "DECLINE_TO_SELF_IDENTIFY")]
    DeclineToSelfIdentify
}
