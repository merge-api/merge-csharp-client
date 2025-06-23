using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CreditNotesRetrieveRequestExpandItem>))]
public readonly record struct CreditNotesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly CreditNotesRetrieveRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly CreditNotesRetrieveRequestExpandItem AppliedPayments = new(
        Values.AppliedPayments
    );

    public static readonly CreditNotesRetrieveRequestExpandItem Company = new(Values.Company);

    public static readonly CreditNotesRetrieveRequestExpandItem Contact = new(Values.Contact);

    public static readonly CreditNotesRetrieveRequestExpandItem LineItems = new(Values.LineItems);

    public static readonly CreditNotesRetrieveRequestExpandItem Payments = new(Values.Payments);

    public static readonly CreditNotesRetrieveRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public CreditNotesRetrieveRequestExpandItem(string value)
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
    public static CreditNotesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new CreditNotesRetrieveRequestExpandItem(value);
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

    public static bool operator ==(CreditNotesRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreditNotesRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreditNotesRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator CreditNotesRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string AccountingPeriod = "accounting_period";

        public const string AppliedPayments = "applied_payments";

        public const string Company = "company";

        public const string Contact = "contact";

        public const string LineItems = "line_items";

        public const string Payments = "payments";

        public const string TrackingCategories = "tracking_categories";
    }
}
