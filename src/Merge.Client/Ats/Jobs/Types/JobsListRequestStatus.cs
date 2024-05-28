using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public enum JobsListRequestStatus
{
    [EnumMember(Value = "ARCHIVED")]
    Archived,

    [EnumMember(Value = "CLOSED")]
    Closed,

    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "PENDING")]
    Pending
}
