using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<EmailAddressTypeEnum>))]
public enum EmailAddressTypeEnum
{
    [EnumMember(Value = "PERSONAL")]
    Personal,

    [EnumMember(Value = "WORK")]
    Work,

    [EnumMember(Value = "OTHER")]
    Other,
}
