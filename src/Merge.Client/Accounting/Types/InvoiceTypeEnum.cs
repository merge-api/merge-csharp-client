using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum InvoiceTypeEnum
{
    [EnumMember(Value = "ACCOUNTS_RECEIVABLE")]
    AccountsReceivable,

    [EnumMember(Value = "ACCOUNTS_PAYABLE")]
    AccountsPayable
}
