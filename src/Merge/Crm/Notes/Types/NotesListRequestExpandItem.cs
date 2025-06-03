using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm.Notes;

[JsonConverter(typeof(StringEnumSerializer<NotesListRequestExpandItem>))]
public readonly record struct NotesListRequestExpandItem : IStringEnum
{
    public static readonly NotesListRequestExpandItem Account = new(Values.Account);

    public static readonly NotesListRequestExpandItem Contact = new(Values.Contact);

    public static readonly NotesListRequestExpandItem Opportunity = new(Values.Opportunity);

    public static readonly NotesListRequestExpandItem Owner = new(Values.Owner);

    public NotesListRequestExpandItem(string value)
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
    public static NotesListRequestExpandItem FromCustom(string value)
    {
        return new NotesListRequestExpandItem(value);
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

    public static bool operator ==(NotesListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NotesListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NotesListRequestExpandItem value) => value.Value;

    public static explicit operator NotesListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Account = "account";

        public const string Contact = "contact";

        public const string Opportunity = "opportunity";

        public const string Owner = "owner";
    }
}
