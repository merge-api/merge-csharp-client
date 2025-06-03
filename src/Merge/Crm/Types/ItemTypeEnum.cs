using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm;

[JsonConverter(typeof(StringEnumSerializer<ItemTypeEnum>))]
public readonly record struct ItemTypeEnum : IStringEnum
{
    public static readonly ItemTypeEnum String = new(Values.String);

    public static readonly ItemTypeEnum Number = new(Values.Number);

    public static readonly ItemTypeEnum Date = new(Values.Date);

    public static readonly ItemTypeEnum Datetime = new(Values.Datetime);

    public static readonly ItemTypeEnum Bool = new(Values.Bool);

    public static readonly ItemTypeEnum List = new(Values.List);

    public ItemTypeEnum(string value)
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
    public static ItemTypeEnum FromCustom(string value)
    {
        return new ItemTypeEnum(value);
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

    public static bool operator ==(ItemTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ItemTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ItemTypeEnum value) => value.Value;

    public static explicit operator ItemTypeEnum(string value) => new(value);

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
