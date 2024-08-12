using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobPostingsListRequestStatus>))]
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
