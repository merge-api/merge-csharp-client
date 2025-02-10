using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<InvoiceStatusEnum>))]
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
    Void,
}
