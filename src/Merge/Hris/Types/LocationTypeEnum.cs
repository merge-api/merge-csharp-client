using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris;

[JsonConverter(typeof(StringEnumSerializer<LocationTypeEnum>))]
public readonly record struct LocationTypeEnum : IStringEnum
{
    public static readonly LocationTypeEnum Home = new(Values.Home);

    public static readonly LocationTypeEnum Work = new(Values.Work);

    public LocationTypeEnum(string value)
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
    public static LocationTypeEnum FromCustom(string value)
    {
        return new LocationTypeEnum(value);
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

    public static bool operator ==(LocationTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LocationTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LocationTypeEnum value) => value.Value;

    public static explicit operator LocationTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Home = "HOME";

        public const string Work = "WORK";
    }
}
