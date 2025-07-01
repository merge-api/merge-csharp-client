using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<AddressTypeEnum>))]
[Serializable]
public readonly record struct AddressTypeEnum : IStringEnum
{
    public static readonly AddressTypeEnum Billing = new(Values.Billing);

    public static readonly AddressTypeEnum Shipping = new(Values.Shipping);

    public AddressTypeEnum(string value)
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
    public static AddressTypeEnum FromCustom(string value)
    {
        return new AddressTypeEnum(value);
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

    public static bool operator ==(AddressTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AddressTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AddressTypeEnum value) => value.Value;

    public static explicit operator AddressTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Billing = "BILLING";

        public const string Shipping = "SHIPPING";
    }
}
