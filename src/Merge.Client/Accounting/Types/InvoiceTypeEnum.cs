using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<InvoiceTypeEnum>))]
public enum InvoiceTypeEnum
{
    [EnumMember(Value = "ACCOUNTS_RECEIVABLE")]
    AccountsReceivable,

    [EnumMember(Value = "ACCOUNTS_PAYABLE")]
    AccountsPayable,
}
