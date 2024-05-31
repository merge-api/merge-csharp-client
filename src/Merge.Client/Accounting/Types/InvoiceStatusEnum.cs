using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Accounting;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<InvoiceStatusEnum>))]
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
