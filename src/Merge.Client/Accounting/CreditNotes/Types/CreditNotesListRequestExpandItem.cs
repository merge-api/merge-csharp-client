using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CreditNotesListRequestExpandItem>))]
[Serializable]
public readonly record struct CreditNotesListRequestExpandItem : IStringEnum
{
    public static readonly CreditNotesListRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly CreditNotesListRequestExpandItem AppliedPayments = new(
        Values.AppliedPayments
    );

    public static readonly CreditNotesListRequestExpandItem Company = new(Values.Company);

    public static readonly CreditNotesListRequestExpandItem Contact = new(Values.Contact);

    public static readonly CreditNotesListRequestExpandItem LineItems = new(Values.LineItems);

    public static readonly CreditNotesListRequestExpandItem Payments = new(Values.Payments);

    public static readonly CreditNotesListRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public CreditNotesListRequestExpandItem(string value)
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
    public static CreditNotesListRequestExpandItem FromCustom(string value)
    {
        return new CreditNotesListRequestExpandItem(value);
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

    public static bool operator ==(CreditNotesListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreditNotesListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreditNotesListRequestExpandItem value) => value.Value;

    public static explicit operator CreditNotesListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
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
