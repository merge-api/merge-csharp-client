using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum IssueStatusEnum
{
    [EnumMember(Value = "ONGOING")]
    Ongoing,

    [EnumMember(Value = "RESOLVED")]
    Resolved
}
