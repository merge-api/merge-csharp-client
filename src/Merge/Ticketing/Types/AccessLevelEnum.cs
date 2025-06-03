using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<AccessLevelEnum>))]
public readonly record struct AccessLevelEnum : IStringEnum
{
    public static readonly AccessLevelEnum Private = new(Values.Private);

    public static readonly AccessLevelEnum Company = new(Values.Company);

    public static readonly AccessLevelEnum Public = new(Values.Public);

    public AccessLevelEnum(string value)
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
    public static AccessLevelEnum FromCustom(string value)
    {
        return new AccessLevelEnum(value);
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

    public static bool operator ==(AccessLevelEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccessLevelEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccessLevelEnum value) => value.Value;

    public static explicit operator AccessLevelEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Private = "PRIVATE";

        public const string Company = "COMPANY";

        public const string Public = "PUBLIC";
    }
}
