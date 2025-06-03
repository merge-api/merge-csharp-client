using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing.Tickets;

[JsonConverter(typeof(StringEnumSerializer<TicketsListRequestExpandItem>))]
public readonly record struct TicketsListRequestExpandItem : IStringEnum
{
    public static readonly TicketsListRequestExpandItem Account = new(Values.Account);

    public static readonly TicketsListRequestExpandItem AssignedTeams = new(Values.AssignedTeams);

    public static readonly TicketsListRequestExpandItem Assignees = new(Values.Assignees);

    public static readonly TicketsListRequestExpandItem Attachments = new(Values.Attachments);

    public static readonly TicketsListRequestExpandItem Collections = new(Values.Collections);

    public static readonly TicketsListRequestExpandItem Contact = new(Values.Contact);

    public static readonly TicketsListRequestExpandItem Creator = new(Values.Creator);

    public static readonly TicketsListRequestExpandItem ParentTicket = new(Values.ParentTicket);

    public TicketsListRequestExpandItem(string value)
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
    public static TicketsListRequestExpandItem FromCustom(string value)
    {
        return new TicketsListRequestExpandItem(value);
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

    public static bool operator ==(TicketsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketsListRequestExpandItem value) => value.Value;

    public static explicit operator TicketsListRequestExpandItem(string value) => new(value);

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
