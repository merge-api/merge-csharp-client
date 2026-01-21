using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<AccountsListRequestClassification>))]
[Serializable]
public readonly record struct AccountsListRequestClassification : IStringEnum
{
    public static readonly AccountsListRequestClassification Empty = new(Values.Empty);

    public static readonly AccountsListRequestClassification Asset = new(Values.Asset);

    public static readonly AccountsListRequestClassification Equity = new(Values.Equity);

    public static readonly AccountsListRequestClassification Expense = new(Values.Expense);

    public static readonly AccountsListRequestClassification Liability = new(Values.Liability);

    public static readonly AccountsListRequestClassification Revenue = new(Values.Revenue);

    public AccountsListRequestClassification(string value)
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
    public static AccountsListRequestClassification FromCustom(string value)
    {
        return new AccountsListRequestClassification(value);
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

    public static bool operator ==(AccountsListRequestClassification value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsListRequestClassification value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsListRequestClassification value) => value.Value;

    public static explicit operator AccountsListRequestClassification(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Empty = "";

        public const string Asset = "ASSET";

        public const string Equity = "EQUITY";

        public const string Expense = "EXPENSE";

        public const string Liability = "LIABILITY";

        public const string Revenue = "REVENUE";
    }
}
