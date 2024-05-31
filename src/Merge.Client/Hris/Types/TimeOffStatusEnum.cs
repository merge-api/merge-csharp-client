using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffStatusEnum>))]
public enum TimeOffStatusEnum
{
    [EnumMember(Value = "REQUESTED")]
    Requested,

    [EnumMember(Value = "APPROVED")]
    Approved,

    [EnumMember(Value = "DECLINED")]
    Declined,

    [EnumMember(Value = "CANCELLED")]
    Cancelled,

    [EnumMember(Value = "DELETED")]
    Deleted
}
