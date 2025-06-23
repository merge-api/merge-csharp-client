using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<UnitsEnum>))]
public readonly record struct UnitsEnum : IStringEnum
{
    public static readonly UnitsEnum Hours = new(Values.Hours);

    public static readonly UnitsEnum Days = new(Values.Days);

    public UnitsEnum(string value)
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
    public static UnitsEnum FromCustom(string value)
    {
        return new UnitsEnum(value);
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

    public static bool operator ==(UnitsEnum value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(UnitsEnum value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(UnitsEnum value) => value.Value;

    public static explicit operator UnitsEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Hours = "HOURS";

        public const string Days = "DAYS";
    }
}
