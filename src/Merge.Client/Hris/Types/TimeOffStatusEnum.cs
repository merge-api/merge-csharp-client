using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<TimeOffStatusEnum>))]
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
    Deleted,
}
