using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum PhoneNumberTypeEnum
{
    [EnumMember(Value = "HOME")]
    Home,

    [EnumMember(Value = "WORK")]
    Work,

    [EnumMember(Value = "MOBILE")]
    Mobile,

    [EnumMember(Value = "SKYPE")]
    Skype,

    [EnumMember(Value = "OTHER")]
    Other
}
