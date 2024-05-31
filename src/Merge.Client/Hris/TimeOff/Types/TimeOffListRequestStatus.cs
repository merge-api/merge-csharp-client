using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffListRequestStatus>))]
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
