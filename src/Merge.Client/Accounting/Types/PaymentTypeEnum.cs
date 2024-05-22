using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum PaymentTypeEnum
{
    [EnumMember(Value = "ACCOUNTS_PAYABLE")]
    AccountsPayable,

    [EnumMember(Value = "ACCOUNTS_RECEIVABLE")]
    AccountsReceivable
}
