using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting;

[JsonConverter(typeof(StringEnumSerializer<AccountAccountTypeEnum>))]
public readonly record struct AccountAccountTypeEnum : IStringEnum
{
    public static readonly AccountAccountTypeEnum Bank = new(Values.Bank);

    public static readonly AccountAccountTypeEnum CreditCard = new(Values.CreditCard);

    public static readonly AccountAccountTypeEnum AccountsPayable = new(Values.AccountsPayable);

    public static readonly AccountAccountTypeEnum AccountsReceivable = new(
        Values.AccountsReceivable
    );

    public static readonly AccountAccountTypeEnum FixedAsset = new(Values.FixedAsset);

    public static readonly AccountAccountTypeEnum OtherAsset = new(Values.OtherAsset);

    public static readonly AccountAccountTypeEnum OtherCurrentAsset = new(Values.OtherCurrentAsset);

    public static readonly AccountAccountTypeEnum OtherExpense = new(Values.OtherExpense);

    public static readonly AccountAccountTypeEnum OtherIncome = new(Values.OtherIncome);

    public static readonly AccountAccountTypeEnum CostOfGoodsSold = new(Values.CostOfGoodsSold);

    public static readonly AccountAccountTypeEnum OtherCurrentLiability = new(
        Values.OtherCurrentLiability
    );

    public static readonly AccountAccountTypeEnum LongTermLiability = new(Values.LongTermLiability);

    public static readonly AccountAccountTypeEnum NonPosting = new(Values.NonPosting);

    public AccountAccountTypeEnum(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static AccountAccountTypeEnum FromCustom(string value)
    {
        return new AccountAccountTypeEnum(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(AccountAccountTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountAccountTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountAccountTypeEnum value) => value.Value;

    public static explicit operator AccountAccountTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Bank = "BANK";

        public const string CreditCard = "CREDIT_CARD";

        public const string AccountsPayable = "ACCOUNTS_PAYABLE";

        public const string AccountsReceivable = "ACCOUNTS_RECEIVABLE";

        public const string FixedAsset = "FIXED_ASSET";

        public const string OtherAsset = "OTHER_ASSET";

        public const string OtherCurrentAsset = "OTHER_CURRENT_ASSET";

        public const string OtherExpense = "OTHER_EXPENSE";

        public const string OtherIncome = "OTHER_INCOME";

        public const string CostOfGoodsSold = "COST_OF_GOODS_SOLD";

        public const string OtherCurrentLiability = "OTHER_CURRENT_LIABILITY";

        public const string LongTermLiability = "LONG_TERM_LIABILITY";

        public const string NonPosting = "NON_POSTING";
    }
}
