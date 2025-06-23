using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<CommentsListRequestExpandItem>))]
public readonly record struct CommentsListRequestExpandItem : IStringEnum
{
    public static readonly CommentsListRequestExpandItem Contact = new(Values.Contact);

    public static readonly CommentsListRequestExpandItem Ticket = new(Values.Ticket);

    public static readonly CommentsListRequestExpandItem User = new(Values.User);

    public CommentsListRequestExpandItem(string value)
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
    public static CommentsListRequestExpandItem FromCustom(string value)
    {
        return new CommentsListRequestExpandItem(value);
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

    public static bool operator ==(CommentsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CommentsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CommentsListRequestExpandItem value) => value.Value;

    public static explicit operator CommentsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Contact = "contact";

        public const string Ticket = "ticket";

        public const string User = "user";
    }
}
