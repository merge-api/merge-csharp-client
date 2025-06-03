using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting.Items;

[JsonConverter(typeof(StringEnumSerializer<ItemsRetrieveRequestExpandItem>))]
public readonly record struct ItemsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly ItemsRetrieveRequestExpandItem Company = new(Values.Company);

    public static readonly ItemsRetrieveRequestExpandItem PurchaseAccount = new(
        Values.PurchaseAccount
    );

    public static readonly ItemsRetrieveRequestExpandItem PurchaseTaxRate = new(
        Values.PurchaseTaxRate
    );

    public static readonly ItemsRetrieveRequestExpandItem SalesAccount = new(Values.SalesAccount);

    public static readonly ItemsRetrieveRequestExpandItem SalesTaxRate = new(Values.SalesTaxRate);

    public ItemsRetrieveRequestExpandItem(string value)
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
    public static ItemsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new ItemsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(ItemsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator ItemsRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Company = "company";

        public const string PurchaseAccount = "purchase_account";

        public const string PurchaseTaxRate = "purchase_tax_rate";

        public const string SalesAccount = "sales_account";

        public const string SalesTaxRate = "sales_tax_rate";
    }
}
