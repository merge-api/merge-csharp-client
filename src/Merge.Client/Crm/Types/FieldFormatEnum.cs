using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<FieldFormatEnum>))]
[Serializable]
public readonly record struct FieldFormatEnum : IStringEnum
{
    public static readonly FieldFormatEnum String = new(Values.String);

    public static readonly FieldFormatEnum Number = new(Values.Number);

    public static readonly FieldFormatEnum Date = new(Values.Date);

    public static readonly FieldFormatEnum Datetime = new(Values.Datetime);

    public static readonly FieldFormatEnum Bool = new(Values.Bool);

    public static readonly FieldFormatEnum List = new(Values.List);

    public FieldFormatEnum(string value)
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
    public static FieldFormatEnum FromCustom(string value)
    {
        return new FieldFormatEnum(value);
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

    public static bool operator ==(FieldFormatEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FieldFormatEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FieldFormatEnum value) => value.Value;

    public static explicit operator FieldFormatEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
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
