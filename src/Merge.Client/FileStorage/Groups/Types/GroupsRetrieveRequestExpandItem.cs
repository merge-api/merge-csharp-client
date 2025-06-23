using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(StringEnumSerializer<GroupsRetrieveRequestExpandItem>))]
public readonly record struct GroupsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly GroupsRetrieveRequestExpandItem ChildGroups = new(Values.ChildGroups);

    public static readonly GroupsRetrieveRequestExpandItem Users = new(Values.Users);

    public GroupsRetrieveRequestExpandItem(string value)
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
    public static GroupsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new GroupsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(GroupsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GroupsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GroupsRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator GroupsRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string ChildGroups = "child_groups";

        public const string Users = "users";
    }
}
