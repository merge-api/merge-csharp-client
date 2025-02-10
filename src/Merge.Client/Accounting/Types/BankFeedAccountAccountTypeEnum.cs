using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<BankFeedAccountAccountTypeEnum>))]
public enum BankFeedAccountAccountTypeEnum
{
    [EnumMember(Value = "BANK")]
    Bank,

    [EnumMember(Value = "CREDIT_CARD")]
    CreditCard,
}
