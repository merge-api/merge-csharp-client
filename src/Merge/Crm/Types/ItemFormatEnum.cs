using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm;

[JsonConverter(typeof(StringEnumSerializer<ItemFormatEnum>))]
public readonly record struct ItemFormatEnum : IStringEnum
{
    public static readonly ItemFormatEnum String = new(Values.String);

    public static readonly ItemFormatEnum Number = new(Values.Number);

    public static readonly ItemFormatEnum Date = new(Values.Date);

    public static readonly ItemFormatEnum Datetime = new(Values.Datetime);

    public static readonly ItemFormatEnum Bool = new(Values.Bool);

    public static readonly ItemFormatEnum List = new(Values.List);

    public ItemFormatEnum(string value)
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
    public static ItemFormatEnum FromCustom(string value)
    {
        return new ItemFormatEnum(value);
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

    public static bool operator ==(ItemFormatEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemFormatEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemFormatEnum value) => value.Value;

    public static explicit operator ItemFormatEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string String = "string";

        public const string Number = "number";

        public const string Date = "date";

        public const string Datetime = "datetime";

        public const string Bool = "bool";

        public const string List = "list";
    }
}
