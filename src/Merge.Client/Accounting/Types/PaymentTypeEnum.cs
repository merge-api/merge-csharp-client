using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum PaymentTypeEnum
{
    [EnumMember(Value = "ACCOUNTS_PAYABLE")]
    AccountsPayable,

    [EnumMember(Value = "ACCOUNTS_RECEIVABLE")]
    AccountsReceivable
}
