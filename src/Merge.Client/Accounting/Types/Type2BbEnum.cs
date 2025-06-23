using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<Type2BbEnum>))]
public readonly record struct Type2BbEnum : IStringEnum
{
    public static readonly Type2BbEnum Inventory = new(Values.Inventory);

    public static readonly Type2BbEnum NonInventory = new(Values.NonInventory);

    public static readonly Type2BbEnum Service = new(Values.Service);

    public static readonly Type2BbEnum Unknown = new(Values.Unknown);

    public Type2BbEnum(string value)
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
    public static Type2BbEnum FromCustom(string value)
    {
        return new Type2BbEnum(value);
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

    public static bool operator ==(Type2BbEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(Type2BbEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(Type2BbEnum value) => value.Value;

    public static explicit operator Type2BbEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Inventory = "INVENTORY";

        public const string NonInventory = "NON_INVENTORY";

        public const string Service = "SERVICE";

        public const string Unknown = "UNKNOWN";
    }
}
