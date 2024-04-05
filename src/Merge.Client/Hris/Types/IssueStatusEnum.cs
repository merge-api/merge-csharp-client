using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum IssueStatusEnum
{
    [EnumMember(Value = "ONGOING")]
    Ongoing,

    [EnumMember(Value = "RESOLVED")]
    Resolved
}
