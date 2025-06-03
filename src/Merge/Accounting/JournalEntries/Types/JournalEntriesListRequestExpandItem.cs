using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting.JournalEntries;

[JsonConverter(typeof(StringEnumSerializer<JournalEntriesListRequestExpandItem>))]
public readonly record struct JournalEntriesListRequestExpandItem : IStringEnum
{
    public static readonly JournalEntriesListRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly JournalEntriesListRequestExpandItem AppliedPayments = new(
        Values.AppliedPayments
    );

    public static readonly JournalEntriesListRequestExpandItem Company = new(Values.Company);

    public static readonly JournalEntriesListRequestExpandItem Lines = new(Values.Lines);

    public static readonly JournalEntriesListRequestExpandItem Payments = new(Values.Payments);

    public static readonly JournalEntriesListRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public JournalEntriesListRequestExpandItem(string value)
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
    public static JournalEntriesListRequestExpandItem FromCustom(string value)
    {
        return new JournalEntriesListRequestExpandItem(value);
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

    public static bool operator ==(JournalEntriesListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JournalEntriesListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JournalEntriesListRequestExpandItem value) =>
        value.Value;

    public static explicit operator JournalEntriesListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string AccountingPeriod = "accounting_period";

        public const string AppliedPayments = "applied_payments";

        public const string Company = "company";

        public const string Lines = "lines";

        public const string Payments = "payments";

        public const string TrackingCategories = "tracking_categories";
    }
}
