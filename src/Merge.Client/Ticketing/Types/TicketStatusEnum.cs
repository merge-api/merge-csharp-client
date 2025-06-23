using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<TicketStatusEnum>))]
public readonly record struct TicketStatusEnum : IStringEnum
{
    public static readonly TicketStatusEnum Open = new(Values.Open);

    public static readonly TicketStatusEnum Closed = new(Values.Closed);

    public static readonly TicketStatusEnum InProgress = new(Values.InProgress);

    public static readonly TicketStatusEnum OnHold = new(Values.OnHold);

    public TicketStatusEnum(string value)
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
    public static TicketStatusEnum FromCustom(string value)
    {
        return new TicketStatusEnum(value);
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

    public static bool operator ==(TicketStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketStatusEnum value) => value.Value;

    public static explicit operator TicketStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Open = "OPEN";

        public const string Closed = "CLOSED";

        public const string InProgress = "IN_PROGRESS";

        public const string OnHold = "ON_HOLD";
    }
}
