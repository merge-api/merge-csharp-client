using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum InvoiceTypeEnum
{
    [EnumMember(Value = "ACCOUNTS_RECEIVABLE")]
    AccountsReceivable,

    [EnumMember(Value = "ACCOUNTS_PAYABLE")]
    AccountsPayable
}
