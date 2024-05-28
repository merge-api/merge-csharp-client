using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum InvoiceStatusEnum
{
    [EnumMember(Value = "PAID")]
    Paid,

    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "SUBMITTED")]
    Submitted,

    [EnumMember(Value = "PARTIALLY_PAID")]
    PartiallyPaid,

    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "VOID")]
    Void
}
