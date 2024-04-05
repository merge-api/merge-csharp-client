using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum JobStatusEnum
{
    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "CLOSED")]
    Closed,

    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "ARCHIVED")]
    Archived,

    [EnumMember(Value = "PENDING")]
    Pending
}
