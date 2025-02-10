using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<AccountAccountTypeEnum>))]
public enum AccountAccountTypeEnum
{
    [EnumMember(Value = "BANK")]
    Bank,

    [EnumMember(Value = "CREDIT_CARD")]
    CreditCard,

    [EnumMember(Value = "ACCOUNTS_PAYABLE")]
    AccountsPayable,

    [EnumMember(Value = "ACCOUNTS_RECEIVABLE")]
    AccountsReceivable,

    [EnumMember(Value = "FIXED_ASSET")]
    FixedAsset,

    [EnumMember(Value = "OTHER_ASSET")]
    OtherAsset,

    [EnumMember(Value = "OTHER_CURRENT_ASSET")]
    OtherCurrentAsset,

    [EnumMember(Value = "OTHER_EXPENSE")]
    OtherExpense,

    [EnumMember(Value = "OTHER_INCOME")]
    OtherIncome,

    [EnumMember(Value = "COST_OF_GOODS_SOLD")]
    CostOfGoodsSold,

    [EnumMember(Value = "OTHER_CURRENT_LIABILITY")]
    OtherCurrentLiability,

    [EnumMember(Value = "LONG_TERM_LIABILITY")]
    LongTermLiability,

    [EnumMember(Value = "NON_POSTING")]
    NonPosting,
}
