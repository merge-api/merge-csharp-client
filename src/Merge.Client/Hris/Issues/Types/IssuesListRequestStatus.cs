using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum IssuesListRequestStatus
{
    [EnumMember(Value = "ONGOING")]
    Ongoing,

    [EnumMember(Value = "RESOLVED")]
    Resolved
}
