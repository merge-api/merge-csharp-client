using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing.Tickets;

[JsonConverter(typeof(StringEnumSerializer<TicketsListRequestPriority>))]
public readonly record struct TicketsListRequestPriority : IStringEnum
{
    public static readonly TicketsListRequestPriority High = new(Values.High);

    public static readonly TicketsListRequestPriority Low = new(Values.Low);

    public static readonly TicketsListRequestPriority Normal = new(Values.Normal);

    public static readonly TicketsListRequestPriority Urgent = new(Values.Urgent);

    public TicketsListRequestPriority(string value)
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
    public static TicketsListRequestPriority FromCustom(string value)
    {
        return new TicketsListRequestPriority(value);
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

    public static bool operator ==(TicketsListRequestPriority value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketsListRequestPriority value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketsListRequestPriority value) => value.Value;

    public static explicit operator TicketsListRequestPriority(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string High = "HIGH";

        public const string Low = "LOW";

        public const string Normal = "NORMAL";

        public const string Urgent = "URGENT";
    }
}
