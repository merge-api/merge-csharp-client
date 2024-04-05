using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum InvoicesListRequestType
{
    [EnumMember(Value = "ACCOUNTS_PAYABLE")]
    AccountsPayable,

    [EnumMember(Value = "ACCOUNTS_RECEIVABLE")]
    AccountsReceivable
}
