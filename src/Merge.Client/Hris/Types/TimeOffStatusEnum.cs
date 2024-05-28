using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

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
