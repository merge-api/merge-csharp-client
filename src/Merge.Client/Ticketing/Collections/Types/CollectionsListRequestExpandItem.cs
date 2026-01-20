using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<CollectionsListRequestExpandItem>))]
[Serializable]
public readonly record struct CollectionsListRequestExpandItem : IStringEnum
{
    public static readonly CollectionsListRequestExpandItem ParentCollection = new(
        Values.ParentCollection
    );

    public CollectionsListRequestExpandItem(string value)
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
    public static CollectionsListRequestExpandItem FromCustom(string value)
    {
        return new CollectionsListRequestExpandItem(value);
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

    public static bool operator ==(CollectionsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CollectionsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CollectionsListRequestExpandItem value) => value.Value;

    public static explicit operator CollectionsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ParentCollection = "parent_collection";
    }
}
