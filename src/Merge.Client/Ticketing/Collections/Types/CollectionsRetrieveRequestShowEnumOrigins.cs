using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<CollectionsRetrieveRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct CollectionsRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly CollectionsRetrieveRequestShowEnumOrigins CollectionType = new(
        Values.CollectionType
    );

    public CollectionsRetrieveRequestShowEnumOrigins(string value)
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
    public static CollectionsRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new CollectionsRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(
        CollectionsRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CollectionsRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CollectionsRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator CollectionsRetrieveRequestShowEnumOrigins(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string CollectionType = "collection_type";
    }
}
