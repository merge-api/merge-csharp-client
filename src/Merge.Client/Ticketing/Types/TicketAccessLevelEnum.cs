using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<TicketAccessLevelEnum>))]
[Serializable]
public readonly record struct TicketAccessLevelEnum : IStringEnum
{
    public static readonly TicketAccessLevelEnum Company = new(Values.Company);

    public static readonly TicketAccessLevelEnum Public = new(Values.Public);

    public static readonly TicketAccessLevelEnum Private = new(Values.Private);

    public static readonly TicketAccessLevelEnum Collection = new(Values.Collection);

    public TicketAccessLevelEnum(string value)
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
    public static TicketAccessLevelEnum FromCustom(string value)
    {
        return new TicketAccessLevelEnum(value);
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

    public static bool operator ==(TicketAccessLevelEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketAccessLevelEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketAccessLevelEnum value) => value.Value;

    public static explicit operator TicketAccessLevelEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Company = "COMPANY";

        public const string Public = "PUBLIC";

        public const string Private = "PRIVATE";

        public const string Collection = "COLLECTION";
    }
}
