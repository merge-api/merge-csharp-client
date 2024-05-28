using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public enum IssueStatusEnum
{
    [EnumMember(Value = "ONGOING")]
    Ongoing,

    [EnumMember(Value = "RESOLVED")]
    Resolved
}
