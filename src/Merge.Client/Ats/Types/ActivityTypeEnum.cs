using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<ActivityTypeEnum>))]
public enum ActivityTypeEnum
{
    [EnumMember(Value = "NOTE")]
    Note,

    [EnumMember(Value = "EMAIL")]
    Email,

    [EnumMember(Value = "OTHER")]
    Other,
}
