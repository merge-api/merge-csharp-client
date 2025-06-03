using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<PriorityEnum>))]
public readonly record struct PriorityEnum : IStringEnum
{
    public static readonly PriorityEnum Urgent = new(Values.Urgent);

    public static readonly PriorityEnum High = new(Values.High);

    public static readonly PriorityEnum Normal = new(Values.Normal);

    public static readonly PriorityEnum Low = new(Values.Low);

    public PriorityEnum(string value)
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
    public static PriorityEnum FromCustom(string value)
    {
        return new PriorityEnum(value);
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

    public static bool operator ==(PriorityEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PriorityEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PriorityEnum value) => value.Value;

    public static explicit operator PriorityEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Urgent = "URGENT";

        public const string High = "HIGH";

        public const string Normal = "NORMAL";

        public const string Low = "LOW";
    }
}
