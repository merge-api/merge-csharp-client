using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<CollectionTypeEnum>))]
public readonly record struct CollectionTypeEnum : IStringEnum
{
    public static readonly CollectionTypeEnum List = new(Values.List);

    public static readonly CollectionTypeEnum Project = new(Values.Project);

    public CollectionTypeEnum(string value)
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
    public static CollectionTypeEnum FromCustom(string value)
    {
        return new CollectionTypeEnum(value);
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

    public static bool operator ==(CollectionTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CollectionTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CollectionTypeEnum value) => value.Value;

    public static explicit operator CollectionTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string List = "LIST";

        public const string Project = "PROJECT";
    }
}
