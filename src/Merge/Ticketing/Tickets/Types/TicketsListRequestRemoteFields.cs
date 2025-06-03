using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing.Tickets;

[JsonConverter(typeof(StringEnumSerializer<TicketsListRequestRemoteFields>))]
public readonly record struct TicketsListRequestRemoteFields : IStringEnum
{
    public static readonly TicketsListRequestRemoteFields Priority = new(Values.Priority);

    public static readonly TicketsListRequestRemoteFields PriorityStatus = new(
        Values.PriorityStatus
    );

    public static readonly TicketsListRequestRemoteFields PriorityStatusTicketType = new(
        Values.PriorityStatusTicketType
    );

    public static readonly TicketsListRequestRemoteFields PriorityTicketType = new(
        Values.PriorityTicketType
    );

    public static readonly TicketsListRequestRemoteFields Status = new(Values.Status);

    public static readonly TicketsListRequestRemoteFields StatusTicketType = new(
        Values.StatusTicketType
    );

    public static readonly TicketsListRequestRemoteFields TicketType = new(Values.TicketType);

    public TicketsListRequestRemoteFields(string value)
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
    public static TicketsListRequestRemoteFields FromCustom(string value)
    {
        return new TicketsListRequestRemoteFields(value);
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

    public static bool operator ==(TicketsListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketsListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketsListRequestRemoteFields value) => value.Value;

    public static explicit operator TicketsListRequestRemoteFields(string value) => new(value);

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
