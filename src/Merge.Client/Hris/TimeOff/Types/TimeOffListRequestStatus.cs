using System.Runtime.Serialization;

namespace Merge.Client.Hris;

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
