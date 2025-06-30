using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<InvoicesListRequestExpandItem>))]
[Serializable]
public readonly record struct InvoicesListRequestExpandItem : IStringEnum
{
    public static readonly InvoicesListRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly InvoicesListRequestExpandItem AppliedCreditNotes = new(
        Values.AppliedCreditNotes
    );

    public static readonly InvoicesListRequestExpandItem AppliedPayments = new(
        Values.AppliedPayments
    );

    public static readonly InvoicesListRequestExpandItem AppliedVendorCredits = new(
        Values.AppliedVendorCredits
    );

    public static readonly InvoicesListRequestExpandItem Company = new(Values.Company);

    public static readonly InvoicesListRequestExpandItem Contact = new(Values.Contact);

    public static readonly InvoicesListRequestExpandItem Employee = new(Values.Employee);

    public static readonly InvoicesListRequestExpandItem LineItems = new(Values.LineItems);

    public static readonly InvoicesListRequestExpandItem PaymentTerm = new(Values.PaymentTerm);

    public static readonly InvoicesListRequestExpandItem Payments = new(Values.Payments);

    public static readonly InvoicesListRequestExpandItem PurchaseOrders = new(
        Values.PurchaseOrders
    );

    public static readonly InvoicesListRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public InvoicesListRequestExpandItem(string value)
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
    public static InvoicesListRequestExpandItem FromCustom(string value)
    {
        return new InvoicesListRequestExpandItem(value);
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

    public static bool operator ==(InvoicesListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesListRequestExpandItem value) => value.Value;

    public static explicit operator InvoicesListRequestExpandItem(string value) => new(value);

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
