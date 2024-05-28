using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public enum JobPostingsListRequestStatus
{
    [EnumMember(Value = "CLOSED")]
    Closed,

    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "INTERNAL")]
    Internal,

    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "PUBLISHED")]
    Published
}
