using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ats;

[JsonConverter(typeof(StringEnumSerializer<VisibilityEnum>))]
public readonly record struct VisibilityEnum : IStringEnum
{
    public static readonly VisibilityEnum AdminOnly = new(Values.AdminOnly);

    public static readonly VisibilityEnum Public = new(Values.Public);

    public static readonly VisibilityEnum Private = new(Values.Private);

    public VisibilityEnum(string value)
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
    public static VisibilityEnum FromCustom(string value)
    {
        return new VisibilityEnum(value);
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

    public static bool operator ==(VisibilityEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VisibilityEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VisibilityEnum value) => value.Value;

    public static explicit operator VisibilityEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string AdminOnly = "ADMIN_ONLY";

        public const string Public = "PUBLIC";

        public const string Private = "PRIVATE";
    }
}
