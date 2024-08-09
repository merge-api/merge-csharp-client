using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobPostingStatusEnum>))]
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
