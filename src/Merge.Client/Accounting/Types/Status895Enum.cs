using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<Status895Enum>))]
[Serializable]
public readonly record struct Status895Enum : IStringEnum
{
    public static readonly Status895Enum Active = new(Values.Active);

    public static readonly Status895Enum Inactive = new(Values.Inactive);

    public Status895Enum(string value)
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
    public static Status895Enum FromCustom(string value)
    {
        return new Status895Enum(value);
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

    public static bool operator ==(Status895Enum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(Status895Enum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(Status895Enum value) => value.Value;

    public static explicit operator Status895Enum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "ACTIVE";

        public const string Inactive = "INACTIVE";
    }
}
