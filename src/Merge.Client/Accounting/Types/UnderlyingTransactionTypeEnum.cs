using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<UnderlyingTransactionTypeEnum>))]
public enum UnderlyingTransactionTypeEnum
{
    [EnumMember(Value = "INVOICE")]
    Invoice,

    [EnumMember(Value = "EXPENSE")]
    Expense,

    [EnumMember(Value = "TRANSACTION")]
    Transaction,

    [EnumMember(Value = "JOURNAL_ENTRY")]
    JournalEntry,

    [EnumMember(Value = "PAYMENT")]
    Payment,

    [EnumMember(Value = "VENDOR_CREDIT")]
    VendorCredit,

    [EnumMember(Value = "CREDIT_NOTE")]
    CreditNote,
}
