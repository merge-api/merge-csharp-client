using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ItemsRetrieveRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct ItemsRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly ItemsRetrieveRequestShowEnumOrigins Status = new(Values.Status);

    public ItemsRetrieveRequestShowEnumOrigins(string value)
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
    public static ItemsRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new ItemsRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(ItemsRetrieveRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsRetrieveRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator ItemsRetrieveRequestShowEnumOrigins(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Status = "status";
    }
}
