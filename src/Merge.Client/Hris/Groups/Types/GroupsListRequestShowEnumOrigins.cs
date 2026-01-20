using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<GroupsListRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct GroupsListRequestShowEnumOrigins : IStringEnum
{
    public static readonly GroupsListRequestShowEnumOrigins Type = new(Values.Type);

    public GroupsListRequestShowEnumOrigins(string value)
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
    public static GroupsListRequestShowEnumOrigins FromCustom(string value)
    {
        return new GroupsListRequestShowEnumOrigins(value);
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

    public static bool operator ==(GroupsListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GroupsListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GroupsListRequestShowEnumOrigins value) => value.Value;

    public static explicit operator GroupsListRequestShowEnumOrigins(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Type = "type";
    }
}
