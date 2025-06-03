using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting.PurchaseOrders;

[JsonConverter(typeof(StringEnumSerializer<PurchaseOrdersListRequestExpandItem>))]
public readonly record struct PurchaseOrdersListRequestExpandItem : IStringEnum
{
    public static readonly PurchaseOrdersListRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly PurchaseOrdersListRequestExpandItem Company = new(Values.Company);

    public static readonly PurchaseOrdersListRequestExpandItem DeliveryAddress = new(
        Values.DeliveryAddress
    );

    public static readonly PurchaseOrdersListRequestExpandItem LineItems = new(Values.LineItems);

    public static readonly PurchaseOrdersListRequestExpandItem PaymentTerm = new(
        Values.PaymentTerm
    );

    public static readonly PurchaseOrdersListRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public static readonly PurchaseOrdersListRequestExpandItem Vendor = new(Values.Vendor);

    public PurchaseOrdersListRequestExpandItem(string value)
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
    public static PurchaseOrdersListRequestExpandItem FromCustom(string value)
    {
        return new PurchaseOrdersListRequestExpandItem(value);
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

    public static bool operator ==(PurchaseOrdersListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PurchaseOrdersListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PurchaseOrdersListRequestExpandItem value) =>
        value.Value;

    public static explicit operator PurchaseOrdersListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
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
