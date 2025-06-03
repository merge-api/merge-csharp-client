using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<TicketAccessEnum>))]
public readonly record struct TicketAccessEnum : IStringEnum
{
    public static readonly TicketAccessEnum All = new(Values.All);

    public static readonly TicketAccessEnum AssignedOnly = new(Values.AssignedOnly);

    public static readonly TicketAccessEnum TeamOnly = new(Values.TeamOnly);

    public TicketAccessEnum(string value)
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
    public static TicketAccessEnum FromCustom(string value)
    {
        return new TicketAccessEnum(value);
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

    public static bool operator ==(TicketAccessEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketAccessEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketAccessEnum value) => value.Value;

    public static explicit operator TicketAccessEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string All = "ALL";

        public const string AssignedOnly = "ASSIGNED_ONLY";

        public const string TeamOnly = "TEAM_ONLY";
    }
}
