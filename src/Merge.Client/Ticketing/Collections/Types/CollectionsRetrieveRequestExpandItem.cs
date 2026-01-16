using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<CollectionsRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct CollectionsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly CollectionsRetrieveRequestExpandItem ParentCollection = new(
        Values.ParentCollection
    );

    public CollectionsRetrieveRequestExpandItem(string value)
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
    public static CollectionsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new CollectionsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(CollectionsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CollectionsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CollectionsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator CollectionsRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ParentCollection = "parent_collection";
    }
}
