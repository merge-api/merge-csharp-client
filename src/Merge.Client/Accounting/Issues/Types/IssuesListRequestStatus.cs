using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<IssuesListRequestStatus>))]
public enum IssuesListRequestStatus
{
    [EnumMember(Value = "ONGOING")]
    Ongoing,

    [EnumMember(Value = "RESOLVED")]
    Resolved,
}
