using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing.Comments;

[JsonConverter(typeof(StringEnumSerializer<CommentsRetrieveRequestExpandItem>))]
public readonly record struct CommentsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly CommentsRetrieveRequestExpandItem Contact = new(Values.Contact);

    public static readonly CommentsRetrieveRequestExpandItem Ticket = new(Values.Ticket);

    public static readonly CommentsRetrieveRequestExpandItem User = new(Values.User);

    public CommentsRetrieveRequestExpandItem(string value)
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
    public static CommentsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new CommentsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(CommentsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CommentsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CommentsRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator CommentsRetrieveRequestExpandItem(string value) => new(value);

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
