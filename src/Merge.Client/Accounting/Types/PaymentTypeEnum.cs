using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<PaymentTypeEnum>))]
public enum PaymentTypeEnum
{
    [EnumMember(Value = "ACCOUNTS_PAYABLE")]
    AccountsPayable,

    [EnumMember(Value = "ACCOUNTS_RECEIVABLE")]
    AccountsReceivable,
}
