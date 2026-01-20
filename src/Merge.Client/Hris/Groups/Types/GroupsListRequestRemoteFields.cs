using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<GroupsListRequestRemoteFields>))]
[Serializable]
public readonly record struct GroupsListRequestRemoteFields : IStringEnum
{
    public static readonly GroupsListRequestRemoteFields Type = new(Values.Type);

    public GroupsListRequestRemoteFields(string value)
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
    public static GroupsListRequestRemoteFields FromCustom(string value)
    {
        return new GroupsListRequestRemoteFields(value);
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

    public static bool operator ==(GroupsListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GroupsListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GroupsListRequestRemoteFields value) => value.Value;

    public static explicit operator GroupsListRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Type = "type";
    }
}
