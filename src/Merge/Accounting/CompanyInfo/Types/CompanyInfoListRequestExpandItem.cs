using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting.CompanyInfo;

[JsonConverter(typeof(StringEnumSerializer<CompanyInfoListRequestExpandItem>))]
public readonly record struct CompanyInfoListRequestExpandItem : IStringEnum
{
    public static readonly CompanyInfoListRequestExpandItem Addresses = new(Values.Addresses);

    public static readonly CompanyInfoListRequestExpandItem PhoneNumbers = new(Values.PhoneNumbers);

    public CompanyInfoListRequestExpandItem(string value)
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
    public static CompanyInfoListRequestExpandItem FromCustom(string value)
    {
        return new CompanyInfoListRequestExpandItem(value);
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

    public static bool operator ==(CompanyInfoListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CompanyInfoListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CompanyInfoListRequestExpandItem value) => value.Value;

    public static explicit operator CompanyInfoListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Addresses = "addresses";

        public const string PhoneNumbers = "phone_numbers";
    }
}
