using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ItemsListRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct ItemsListRequestShowEnumOrigins : IStringEnum
{
    public static readonly ItemsListRequestShowEnumOrigins Status = new(Values.Status);

    public ItemsListRequestShowEnumOrigins(string value)
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
    public static ItemsListRequestShowEnumOrigins FromCustom(string value)
    {
        return new ItemsListRequestShowEnumOrigins(value);
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

    public static bool operator ==(ItemsListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemsListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemsListRequestShowEnumOrigins value) => value.Value;

    public static explicit operator ItemsListRequestShowEnumOrigins(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Status = "status";
    }
}
