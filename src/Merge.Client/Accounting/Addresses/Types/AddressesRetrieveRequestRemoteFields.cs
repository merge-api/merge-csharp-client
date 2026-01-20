using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<AddressesRetrieveRequestRemoteFields>))]
[Serializable]
public readonly record struct AddressesRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly AddressesRetrieveRequestRemoteFields Type = new(Values.Type);

    public AddressesRetrieveRequestRemoteFields(string value)
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
    public static AddressesRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new AddressesRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(AddressesRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AddressesRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AddressesRetrieveRequestRemoteFields value) =>
        value.Value;

    public static explicit operator AddressesRetrieveRequestRemoteFields(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Type = "type";
    }
}
