using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ActivityTypeEnum>))]
public enum ActivityTypeEnum
{
    [EnumMember(Value = "NOTE")]
    Note,

    [EnumMember(Value = "EMAIL")]
    Email,

    [EnumMember(Value = "OTHER")]
    Other
}
