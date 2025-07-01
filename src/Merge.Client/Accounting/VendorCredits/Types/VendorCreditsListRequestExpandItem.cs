using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<VendorCreditsListRequestExpandItem>))]
[Serializable]
public readonly record struct VendorCreditsListRequestExpandItem : IStringEnum
{
    public static readonly VendorCreditsListRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly VendorCreditsListRequestExpandItem Company = new(Values.Company);

    public static readonly VendorCreditsListRequestExpandItem Lines = new(Values.Lines);

    public static readonly VendorCreditsListRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public static readonly VendorCreditsListRequestExpandItem Vendor = new(Values.Vendor);

    public VendorCreditsListRequestExpandItem(string value)
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
    public static VendorCreditsListRequestExpandItem FromCustom(string value)
    {
        return new VendorCreditsListRequestExpandItem(value);
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

    public static bool operator ==(VendorCreditsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VendorCreditsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VendorCreditsListRequestExpandItem value) => value.Value;

    public static explicit operator VendorCreditsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AccountingPeriod = "accounting_period";

        public const string Company = "company";

        public const string Lines = "lines";

        public const string TrackingCategories = "tracking_categories";

        public const string Vendor = "vendor";
    }
}
