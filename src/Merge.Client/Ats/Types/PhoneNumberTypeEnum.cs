using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<PhoneNumberTypeEnum>))]
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
    Other,
}
