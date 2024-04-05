using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum TimeOffListRequestStatus
{
    [EnumMember(Value = "APPROVED")]
    Approved,

    [EnumMember(Value = "CANCELLED")]
    Cancelled,

    [EnumMember(Value = "DECLINED")]
    Declined,

    [EnumMember(Value = "DELETED")]
    Deleted,

    [EnumMember(Value = "REQUESTED")]
    Requested
}
