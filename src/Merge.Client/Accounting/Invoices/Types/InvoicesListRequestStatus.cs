using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<InvoicesListRequestStatus>))]
public enum InvoicesListRequestStatus
{
    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "PAID")]
    Paid,

    [EnumMember(Value = "PARTIALLY_PAID")]
    PartiallyPaid,

    [EnumMember(Value = "SUBMITTED")]
    Submitted,

    [EnumMember(Value = "VOID")]
    Void,
}
