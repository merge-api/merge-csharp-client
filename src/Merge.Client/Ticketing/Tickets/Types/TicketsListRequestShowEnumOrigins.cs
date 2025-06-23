using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<TicketsListRequestShowEnumOrigins>))]
public readonly record struct TicketsListRequestShowEnumOrigins : IStringEnum
{
    public static readonly TicketsListRequestShowEnumOrigins Priority = new(Values.Priority);

    public static readonly TicketsListRequestShowEnumOrigins PriorityStatus = new(
        Values.PriorityStatus
    );

    public static readonly TicketsListRequestShowEnumOrigins PriorityStatusTicketType = new(
        Values.PriorityStatusTicketType
    );

    public static readonly TicketsListRequestShowEnumOrigins PriorityTicketType = new(
        Values.PriorityTicketType
    );

    public static readonly TicketsListRequestShowEnumOrigins Status = new(Values.Status);

    public static readonly TicketsListRequestShowEnumOrigins StatusTicketType = new(
        Values.StatusTicketType
    );

    public static readonly TicketsListRequestShowEnumOrigins TicketType = new(Values.TicketType);

    public TicketsListRequestShowEnumOrigins(string value)
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
    public static TicketsListRequestShowEnumOrigins FromCustom(string value)
    {
        return new TicketsListRequestShowEnumOrigins(value);
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

    public static bool operator ==(TicketsListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketsListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketsListRequestShowEnumOrigins value) => value.Value;

    public static explicit operator TicketsListRequestShowEnumOrigins(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Priority = "priority";

        public const string PriorityStatus = "priority,status";

        public const string PriorityStatusTicketType = "priority,status,ticket_type";

        public const string PriorityTicketType = "priority,ticket_type";

        public const string Status = "status";

        public const string StatusTicketType = "status,ticket_type";

        public const string TicketType = "ticket_type";
    }
}
