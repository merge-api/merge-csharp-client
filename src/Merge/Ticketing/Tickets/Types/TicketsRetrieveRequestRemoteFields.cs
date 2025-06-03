using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing.Tickets;

[JsonConverter(typeof(StringEnumSerializer<TicketsRetrieveRequestRemoteFields>))]
public readonly record struct TicketsRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly TicketsRetrieveRequestRemoteFields Priority = new(Values.Priority);

    public static readonly TicketsRetrieveRequestRemoteFields PriorityStatus = new(
        Values.PriorityStatus
    );

    public static readonly TicketsRetrieveRequestRemoteFields PriorityStatusTicketType = new(
        Values.PriorityStatusTicketType
    );

    public static readonly TicketsRetrieveRequestRemoteFields PriorityTicketType = new(
        Values.PriorityTicketType
    );

    public static readonly TicketsRetrieveRequestRemoteFields Status = new(Values.Status);

    public static readonly TicketsRetrieveRequestRemoteFields StatusTicketType = new(
        Values.StatusTicketType
    );

    public static readonly TicketsRetrieveRequestRemoteFields TicketType = new(Values.TicketType);

    public TicketsRetrieveRequestRemoteFields(string value)
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
    public static TicketsRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new TicketsRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(TicketsRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketsRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketsRetrieveRequestRemoteFields value) => value.Value;

    public static explicit operator TicketsRetrieveRequestRemoteFields(string value) => new(value);

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
