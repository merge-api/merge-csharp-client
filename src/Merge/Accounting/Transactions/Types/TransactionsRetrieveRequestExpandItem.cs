using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting.Transactions;

[JsonConverter(typeof(StringEnumSerializer<TransactionsRetrieveRequestExpandItem>))]
public readonly record struct TransactionsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly TransactionsRetrieveRequestExpandItem Account = new(Values.Account);

    public static readonly TransactionsRetrieveRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly TransactionsRetrieveRequestExpandItem Contact = new(Values.Contact);

    public static readonly TransactionsRetrieveRequestExpandItem LineItems = new(Values.LineItems);

    public static readonly TransactionsRetrieveRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public TransactionsRetrieveRequestExpandItem(string value)
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
    public static TransactionsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new TransactionsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(TransactionsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TransactionsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TransactionsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator TransactionsRetrieveRequestExpandItem(string value) =>
        new(value);

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
