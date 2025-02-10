using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<RunStateEnum>))]
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
