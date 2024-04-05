using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum JobsListRequestStatus
{
    [EnumMember(Value = "ARCHIVED")]
    Archived,

    [EnumMember(Value = "CLOSED")]
    Closed,

    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "PENDING")]
    Pending
}
