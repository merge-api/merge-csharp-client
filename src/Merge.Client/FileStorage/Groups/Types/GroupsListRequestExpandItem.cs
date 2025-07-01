using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(StringEnumSerializer<GroupsListRequestExpandItem>))]
[Serializable]
public readonly record struct GroupsListRequestExpandItem : IStringEnum
{
    public static readonly GroupsListRequestExpandItem ChildGroups = new(Values.ChildGroups);

    public static readonly GroupsListRequestExpandItem Users = new(Values.Users);

    public GroupsListRequestExpandItem(string value)
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
    public static GroupsListRequestExpandItem FromCustom(string value)
    {
        return new GroupsListRequestExpandItem(value);
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

    public static bool operator ==(GroupsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GroupsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GroupsListRequestExpandItem value) => value.Value;

    public static explicit operator GroupsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ChildGroups = "child_groups";

        public const string Users = "users";
    }
}
