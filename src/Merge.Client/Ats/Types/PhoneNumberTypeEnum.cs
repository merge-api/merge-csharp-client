using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<PhoneNumberTypeEnum>))]
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
