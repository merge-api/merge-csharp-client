using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<PurchaseOrdersRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct PurchaseOrdersRetrieveRequestExpandItem : IStringEnum
{
    public static readonly PurchaseOrdersRetrieveRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly PurchaseOrdersRetrieveRequestExpandItem Company = new(Values.Company);

    public static readonly PurchaseOrdersRetrieveRequestExpandItem DeliveryAddress = new(
        Values.DeliveryAddress
    );

    public static readonly PurchaseOrdersRetrieveRequestExpandItem LineItems = new(
        Values.LineItems
    );

    public static readonly PurchaseOrdersRetrieveRequestExpandItem PaymentTerm = new(
        Values.PaymentTerm
    );

    public static readonly PurchaseOrdersRetrieveRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public static readonly PurchaseOrdersRetrieveRequestExpandItem Vendor = new(Values.Vendor);

    public PurchaseOrdersRetrieveRequestExpandItem(string value)
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
    public static PurchaseOrdersRetrieveRequestExpandItem FromCustom(string value)
    {
        return new PurchaseOrdersRetrieveRequestExpandItem(value);
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

    public static bool operator ==(PurchaseOrdersRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PurchaseOrdersRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PurchaseOrdersRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator PurchaseOrdersRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AccountingPeriod = "accounting_period";

        public const string Company = "company";

        public const string DeliveryAddress = "delivery_address";

        public const string LineItems = "line_items";

        public const string PaymentTerm = "payment_term";

        public const string TrackingCategories = "tracking_categories";

        public const string Vendor = "vendor";
    }
}
