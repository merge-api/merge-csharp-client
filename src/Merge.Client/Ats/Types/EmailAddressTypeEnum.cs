using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<EmailAddressTypeEnum>))]
public enum EmailAddressTypeEnum
{
    [EnumMember(Value = "PERSONAL")]
    Personal,

    [EnumMember(Value = "WORK")]
    Work,

    [EnumMember(Value = "OTHER")]
    Other,
}
