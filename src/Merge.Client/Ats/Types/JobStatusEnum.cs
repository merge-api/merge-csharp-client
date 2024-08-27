using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobStatusEnum>))]
public enum JobStatusEnum
{
    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "CLOSED")]
    Closed,

    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "ARCHIVED")]
    Archived,

    [EnumMember(Value = "PENDING")]
    Pending,
}
