using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum InvoiceTypeEnum
{
    [EnumMember(Value = "ACCOUNTS_RECEIVABLE")]
    AccountsReceivable,

    [EnumMember(Value = "ACCOUNTS_PAYABLE")]
    AccountsPayable
}
