using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<ActivityTypeEnum>))]
public enum ActivityTypeEnum
{
    [EnumMember(Value = "CALL")]
    Call,

    [EnumMember(Value = "MEETING")]
    Meeting,

    [EnumMember(Value = "EMAIL")]
    Email
}
