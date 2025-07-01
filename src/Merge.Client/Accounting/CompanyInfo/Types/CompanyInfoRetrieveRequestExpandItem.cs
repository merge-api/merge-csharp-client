using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CompanyInfoRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct CompanyInfoRetrieveRequestExpandItem : IStringEnum
{
    public static readonly CompanyInfoRetrieveRequestExpandItem Addresses = new(Values.Addresses);

    public static readonly CompanyInfoRetrieveRequestExpandItem PhoneNumbers = new(
        Values.PhoneNumbers
    );

    public CompanyInfoRetrieveRequestExpandItem(string value)
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
    public static CompanyInfoRetrieveRequestExpandItem FromCustom(string value)
    {
        return new CompanyInfoRetrieveRequestExpandItem(value);
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

    public static bool operator ==(CompanyInfoRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CompanyInfoRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CompanyInfoRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator CompanyInfoRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Addresses = "addresses";

        public const string PhoneNumbers = "phone_numbers";
    }
}
