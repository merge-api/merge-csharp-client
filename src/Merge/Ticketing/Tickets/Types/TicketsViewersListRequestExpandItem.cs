using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing.Tickets;

[JsonConverter(typeof(StringEnumSerializer<TicketsViewersListRequestExpandItem>))]
public readonly record struct TicketsViewersListRequestExpandItem : IStringEnum
{
    public static readonly TicketsViewersListRequestExpandItem Team = new(Values.Team);

    public static readonly TicketsViewersListRequestExpandItem User = new(Values.User);

    public TicketsViewersListRequestExpandItem(string value)
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
    public static TicketsViewersListRequestExpandItem FromCustom(string value)
    {
        return new TicketsViewersListRequestExpandItem(value);
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

    public static bool operator ==(TicketsViewersListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketsViewersListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketsViewersListRequestExpandItem value) =>
        value.Value;

    public static explicit operator TicketsViewersListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Team = "team";

        public const string User = "user";
    }
}
