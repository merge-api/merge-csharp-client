using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<JournalEntriesRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct JournalEntriesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly JournalEntriesRetrieveRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly JournalEntriesRetrieveRequestExpandItem AppliedPayments = new(
        Values.AppliedPayments
    );

    public static readonly JournalEntriesRetrieveRequestExpandItem Company = new(Values.Company);

    public static readonly JournalEntriesRetrieveRequestExpandItem Lines = new(Values.Lines);

    public static readonly JournalEntriesRetrieveRequestExpandItem Payments = new(Values.Payments);

    public static readonly JournalEntriesRetrieveRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public JournalEntriesRetrieveRequestExpandItem(string value)
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
    public static JournalEntriesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new JournalEntriesRetrieveRequestExpandItem(value);
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

    public static bool operator ==(JournalEntriesRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JournalEntriesRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JournalEntriesRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator JournalEntriesRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
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
