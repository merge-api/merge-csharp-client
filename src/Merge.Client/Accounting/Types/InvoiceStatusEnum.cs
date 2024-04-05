using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(TolerantEnumConverter))]
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
