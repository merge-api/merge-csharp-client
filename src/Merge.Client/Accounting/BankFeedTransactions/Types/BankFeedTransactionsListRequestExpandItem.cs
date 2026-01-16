using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<BankFeedTransactionsListRequestExpandItem>))]
[Serializable]
public readonly record struct BankFeedTransactionsListRequestExpandItem : IStringEnum
{
    public static readonly BankFeedTransactionsListRequestExpandItem BankFeedAccount = new(
        Values.BankFeedAccount
    );

    public BankFeedTransactionsListRequestExpandItem(string value)
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
    public static BankFeedTransactionsListRequestExpandItem FromCustom(string value)
    {
        return new BankFeedTransactionsListRequestExpandItem(value);
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

    public static bool operator ==(
        BankFeedTransactionsListRequestExpandItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BankFeedTransactionsListRequestExpandItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(BankFeedTransactionsListRequestExpandItem value) =>
        value.Value;

    public static explicit operator BankFeedTransactionsListRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string BankFeedAccount = "bank_feed_account";
    }
}
