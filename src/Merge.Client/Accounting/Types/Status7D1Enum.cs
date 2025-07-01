using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<Status7D1Enum>))]
[Serializable]
public readonly record struct Status7D1Enum : IStringEnum
{
    public static readonly Status7D1Enum Active = new(Values.Active);

    public static readonly Status7D1Enum Archived = new(Values.Archived);

    public Status7D1Enum(string value)
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
    public static Status7D1Enum FromCustom(string value)
    {
        return new Status7D1Enum(value);
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

    public static bool operator ==(Status7D1Enum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(Status7D1Enum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(Status7D1Enum value) => value.Value;

    public static explicit operator Status7D1Enum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "ACTIVE";

        public const string Archived = "ARCHIVED";
    }
}
