using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public enum IssuesListRequestStatus
{
    [EnumMember(Value = "ONGOING")]
    Ongoing,

    [EnumMember(Value = "RESOLVED")]
    Resolved
}
