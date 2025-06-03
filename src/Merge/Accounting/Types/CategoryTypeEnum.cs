using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CategoryTypeEnum>))]
public readonly record struct CategoryTypeEnum : IStringEnum
{
    public static readonly CategoryTypeEnum Class = new(Values.Class);

    public static readonly CategoryTypeEnum Department = new(Values.Department);

    public CategoryTypeEnum(string value)
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
    public static CategoryTypeEnum FromCustom(string value)
    {
        return new CategoryTypeEnum(value);
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

    public static bool operator ==(CategoryTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CategoryTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CategoryTypeEnum value) => value.Value;

    public static explicit operator CategoryTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Class = "CLASS";

        public const string Department = "DEPARTMENT";
    }
}
