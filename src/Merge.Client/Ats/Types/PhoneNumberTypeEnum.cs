using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
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
