using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<TicketsRetrieveRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct TicketsRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly TicketsRetrieveRequestShowEnumOrigins Priority = new(Values.Priority);

    public static readonly TicketsRetrieveRequestShowEnumOrigins PriorityStatus = new(
        Values.PriorityStatus
    );

    public static readonly TicketsRetrieveRequestShowEnumOrigins PriorityStatusTicketType = new(
        Values.PriorityStatusTicketType
    );

    public static readonly TicketsRetrieveRequestShowEnumOrigins PriorityTicketType = new(
        Values.PriorityTicketType
    );

    public static readonly TicketsRetrieveRequestShowEnumOrigins Status = new(Values.Status);

    public static readonly TicketsRetrieveRequestShowEnumOrigins StatusTicketType = new(
        Values.StatusTicketType
    );

    public static readonly TicketsRetrieveRequestShowEnumOrigins TicketType = new(
        Values.TicketType
    );

    public TicketsRetrieveRequestShowEnumOrigins(string value)
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
    public static TicketsRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new TicketsRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(TicketsRetrieveRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketsRetrieveRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketsRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator TicketsRetrieveRequestShowEnumOrigins(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
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
