using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<TransactionsListRequestExpandItem>))]
public readonly record struct TransactionsListRequestExpandItem : IStringEnum
{
    public static readonly TransactionsListRequestExpandItem Account = new(Values.Account);

    public static readonly TransactionsListRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly TransactionsListRequestExpandItem Contact = new(Values.Contact);

    public static readonly TransactionsListRequestExpandItem LineItems = new(Values.LineItems);

    public static readonly TransactionsListRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public TransactionsListRequestExpandItem(string value)
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
    public static TransactionsListRequestExpandItem FromCustom(string value)
    {
        return new TransactionsListRequestExpandItem(value);
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

    public static bool operator ==(TransactionsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TransactionsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TransactionsListRequestExpandItem value) => value.Value;

    public static explicit operator TransactionsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Account = "account";

        public const string AccountingPeriod = "accounting_period";

        public const string Contact = "contact";

        public const string LineItems = "line_items";

        public const string TrackingCategories = "tracking_categories";
    }
}
