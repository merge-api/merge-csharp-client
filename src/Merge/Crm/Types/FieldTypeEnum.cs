using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm;

[JsonConverter(typeof(StringEnumSerializer<FieldTypeEnum>))]
public readonly record struct FieldTypeEnum : IStringEnum
{
    public static readonly FieldTypeEnum String = new(Values.String);

    public static readonly FieldTypeEnum Number = new(Values.Number);

    public static readonly FieldTypeEnum Date = new(Values.Date);

    public static readonly FieldTypeEnum Datetime = new(Values.Datetime);

    public static readonly FieldTypeEnum Bool = new(Values.Bool);

    public static readonly FieldTypeEnum List = new(Values.List);

    public FieldTypeEnum(string value)
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
    public static FieldTypeEnum FromCustom(string value)
    {
        return new FieldTypeEnum(value);
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

    public static bool operator ==(FieldTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FieldTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FieldTypeEnum value) => value.Value;

    public static explicit operator FieldTypeEnum(string value) => new(value);

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
