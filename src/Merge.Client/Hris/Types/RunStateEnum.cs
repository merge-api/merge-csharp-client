using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

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
