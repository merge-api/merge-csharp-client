using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<IssuesListRequestStatus>))]
public enum IssuesListRequestStatus
{
    [EnumMember(Value = "ONGOING")]
    Ongoing,

    [EnumMember(Value = "RESOLVED")]
    Resolved
}
