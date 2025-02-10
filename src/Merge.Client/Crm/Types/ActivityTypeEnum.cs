using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<ActivityTypeEnum>))]
public enum ActivityTypeEnum
{
    [EnumMember(Value = "CALL")]
    Call,

    [EnumMember(Value = "MEETING")]
    Meeting,

    [EnumMember(Value = "EMAIL")]
    Email,
}
