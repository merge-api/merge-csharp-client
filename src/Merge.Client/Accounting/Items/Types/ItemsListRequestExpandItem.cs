using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ItemsListRequestExpandItem>))]
[Serializable]
public readonly record struct ItemsListRequestExpandItem : IStringEnum
{
    public static readonly ItemsListRequestExpandItem Company = new(Values.Company);

    public static readonly ItemsListRequestExpandItem PurchaseAccount = new(Values.PurchaseAccount);

    public static readonly ItemsListRequestExpandItem PurchaseTaxRate = new(Values.PurchaseTaxRate);

    public static readonly ItemsListRequestExpandItem SalesAccount = new(Values.SalesAccount);

    public static readonly ItemsListRequestExpandItem SalesTaxRate = new(Values.SalesTaxRate);

    public ItemsListRequestExpandItem(string value)
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
    public static ItemsListRequestExpandItem FromCustom(string value)
    {
        return new ItemsListRequestExpandItem(value);
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

    public static bool operator ==(ItemsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsListRequestExpandItem value) => value.Value;

    public static explicit operator ItemsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Company = "company";

        public const string PurchaseAccount = "purchase_account";

        public const string PurchaseTaxRate = "purchase_tax_rate";

        public const string SalesAccount = "sales_account";

        public const string SalesTaxRate = "sales_tax_rate";
    }
}
