using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing.Tickets;

[JsonConverter(typeof(StringEnumSerializer<TicketsRetrieveRequestExpandItem>))]
public readonly record struct TicketsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly TicketsRetrieveRequestExpandItem Account = new(Values.Account);

    public static readonly TicketsRetrieveRequestExpandItem AssignedTeams = new(
        Values.AssignedTeams
    );

    public static readonly TicketsRetrieveRequestExpandItem Assignees = new(Values.Assignees);

    public static readonly TicketsRetrieveRequestExpandItem Attachments = new(Values.Attachments);

    public static readonly TicketsRetrieveRequestExpandItem Collections = new(Values.Collections);

    public static readonly TicketsRetrieveRequestExpandItem Contact = new(Values.Contact);

    public static readonly TicketsRetrieveRequestExpandItem Creator = new(Values.Creator);

    public static readonly TicketsRetrieveRequestExpandItem ParentTicket = new(Values.ParentTicket);

    public TicketsRetrieveRequestExpandItem(string value)
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
    public static TicketsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new TicketsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(TicketsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketsRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator TicketsRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Account = "account";

        public const string AssignedTeams = "assigned_teams";

        public const string Assignees = "assignees";

        public const string Attachments = "attachments";

        public const string Collections = "collections";

        public const string Contact = "contact";

        public const string Creator = "creator";

        public const string ParentTicket = "parent_ticket";
    }
}
