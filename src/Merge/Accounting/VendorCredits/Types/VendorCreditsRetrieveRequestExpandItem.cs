using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting.VendorCredits;

[JsonConverter(typeof(StringEnumSerializer<VendorCreditsRetrieveRequestExpandItem>))]
public readonly record struct VendorCreditsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly VendorCreditsRetrieveRequestExpandItem AccountingPeriod = new(
        Values.AccountingPeriod
    );

    public static readonly VendorCreditsRetrieveRequestExpandItem Company = new(Values.Company);

    public static readonly VendorCreditsRetrieveRequestExpandItem Lines = new(Values.Lines);

    public static readonly VendorCreditsRetrieveRequestExpandItem TrackingCategories = new(
        Values.TrackingCategories
    );

    public static readonly VendorCreditsRetrieveRequestExpandItem Vendor = new(Values.Vendor);

    public VendorCreditsRetrieveRequestExpandItem(string value)
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
    public static VendorCreditsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new VendorCreditsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(VendorCreditsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VendorCreditsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VendorCreditsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator VendorCreditsRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string AccountingPeriod = "accounting_period";

        public const string Company = "company";

        public const string Lines = "lines";

        public const string TrackingCategories = "tracking_categories";

        public const string Vendor = "vendor";
    }
}
