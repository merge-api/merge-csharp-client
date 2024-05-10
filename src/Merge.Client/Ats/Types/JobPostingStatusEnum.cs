using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum JobPostingStatusEnum
{
    [EnumMember(Value = "PUBLISHED")]
    Published,

    [EnumMember(Value = "CLOSED")]
    Closed,

    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "INTERNAL")]
    Internal,

    [EnumMember(Value = "PENDING")]
    Pending
}
