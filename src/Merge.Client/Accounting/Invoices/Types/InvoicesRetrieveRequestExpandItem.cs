using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<InvoicesRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct InvoicesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly InvoicesRetrieveRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly InvoicesRetrieveRequestExpandItem AppliedCreditNotes = new(
        Values.AppliedCreditNotes
    );

    public static readonly InvoicesRetrieveRequestExpandItem AppliedPayments = new(
        Values.AppliedPayments
    );

    public static readonly InvoicesRetrieveRequestExpandItem AppliedVendorCredits = new(
        Values.AppliedVendorCredits
    );

    public static readonly InvoicesRetrieveRequestExpandItem Company = new(Values.Company);

    public static readonly InvoicesRetrieveRequestExpandItem Contact = new(Values.Contact);

    public static readonly InvoicesRetrieveRequestExpandItem Employee = new(Values.Employee);

    public static readonly InvoicesRetrieveRequestExpandItem LineItems = new(Values.LineItems);

    public static readonly InvoicesRetrieveRequestExpandItem PaymentTerm = new(Values.PaymentTerm);

    public static readonly InvoicesRetrieveRequestExpandItem Payments = new(Values.Payments);

    public static readonly InvoicesRetrieveRequestExpandItem PurchaseOrders = new(
        Values.PurchaseOrders
    );

    public static readonly InvoicesRetrieveRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public InvoicesRetrieveRequestExpandItem(string value)
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
    public static InvoicesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new InvoicesRetrieveRequestExpandItem(value);
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

    public static bool operator ==(InvoicesRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator InvoicesRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AccountingPeriod = "accounting_period";

        public const string AppliedCreditNotes = "applied_credit_notes";

        public const string AppliedPayments = "applied_payments";

        public const string AppliedVendorCredits = "applied_vendor_credits";

        public const string Company = "company";

        public const string Contact = "contact";

        public const string Employee = "employee";

        public const string LineItems = "line_items";

        public const string PaymentTerm = "payment_term";

        public const string Payments = "payments";

        public const string PurchaseOrders = "purchase_orders";

        public const string TrackingCategories = "tracking_categories";
    }
}
