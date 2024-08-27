using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<RunStateEnum>))]
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
    Closed,
}
