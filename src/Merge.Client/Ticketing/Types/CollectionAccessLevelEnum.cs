using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<CollectionAccessLevelEnum>))]
[Serializable]
public readonly record struct CollectionAccessLevelEnum : IStringEnum
{
    public static readonly CollectionAccessLevelEnum Private = new(Values.Private);

    public static readonly CollectionAccessLevelEnum Company = new(Values.Company);

    public static readonly CollectionAccessLevelEnum Public = new(Values.Public);

    public static readonly CollectionAccessLevelEnum ParentCollection = new(
        Values.ParentCollection
    );

    public CollectionAccessLevelEnum(string value)
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
    public static CollectionAccessLevelEnum FromCustom(string value)
    {
        return new CollectionAccessLevelEnum(value);
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

    public static bool operator ==(CollectionAccessLevelEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CollectionAccessLevelEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CollectionAccessLevelEnum value) => value.Value;

    public static explicit operator CollectionAccessLevelEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Private = "PRIVATE";

        public const string Company = "COMPANY";

        public const string Public = "PUBLIC";

        public const string ParentCollection = "PARENT_COLLECTION";
    }
}
