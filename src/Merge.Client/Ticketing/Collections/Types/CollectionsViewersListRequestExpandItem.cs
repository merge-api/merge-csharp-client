using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<CollectionsViewersListRequestExpandItem>))]
[Serializable]
public readonly record struct CollectionsViewersListRequestExpandItem : IStringEnum
{
    public static readonly CollectionsViewersListRequestExpandItem Team = new(Values.Team);

    public static readonly CollectionsViewersListRequestExpandItem User = new(Values.User);

    public CollectionsViewersListRequestExpandItem(string value)
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
    public static CollectionsViewersListRequestExpandItem FromCustom(string value)
    {
        return new CollectionsViewersListRequestExpandItem(value);
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

    public static bool operator ==(CollectionsViewersListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CollectionsViewersListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CollectionsViewersListRequestExpandItem value) =>
        value.Value;

    public static explicit operator CollectionsViewersListRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Team = "team";

        public const string User = "user";
    }
}
