using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum RunStateEnum
{
    [EnumMember(Value = "PAID")]
    Paid,

    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "APPROVED")]
    Approved,

    [EnumMember(Value = "FAILED")]
    Failed,

    [EnumMember(Value = "CLOSED")]
    Closed
}
