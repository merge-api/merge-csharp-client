using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
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
