using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<CollectionsRetrieveRequestRemoteFields>))]
[Serializable]
public readonly record struct CollectionsRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly CollectionsRetrieveRequestRemoteFields CollectionType = new(
        Values.CollectionType
    );

    public CollectionsRetrieveRequestRemoteFields(string value)
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
    public static CollectionsRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new CollectionsRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(CollectionsRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CollectionsRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CollectionsRetrieveRequestRemoteFields value) =>
        value.Value;

    public static explicit operator CollectionsRetrieveRequestRemoteFields(string value) =>
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
