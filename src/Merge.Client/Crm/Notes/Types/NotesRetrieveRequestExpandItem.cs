using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<NotesRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct NotesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly NotesRetrieveRequestExpandItem Account = new(Values.Account);

    public static readonly NotesRetrieveRequestExpandItem Contact = new(Values.Contact);

    public static readonly NotesRetrieveRequestExpandItem Opportunity = new(Values.Opportunity);

    public static readonly NotesRetrieveRequestExpandItem Owner = new(Values.Owner);

    public NotesRetrieveRequestExpandItem(string value)
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
    public static NotesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new NotesRetrieveRequestExpandItem(value);
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

    public static bool operator ==(NotesRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NotesRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NotesRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator NotesRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Account = "account";

        public const string Contact = "contact";

        public const string Opportunity = "opportunity";

        public const string Owner = "owner";
    }
}
