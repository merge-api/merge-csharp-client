using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<ProjectsUsersListRequestExpandItem>))]
[Serializable]
public readonly record struct ProjectsUsersListRequestExpandItem : IStringEnum
{
    public static readonly ProjectsUsersListRequestExpandItem Roles = new(Values.Roles);

    public static readonly ProjectsUsersListRequestExpandItem Teams = new(Values.Teams);

    public ProjectsUsersListRequestExpandItem(string value)
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
    public static ProjectsUsersListRequestExpandItem FromCustom(string value)
    {
        return new ProjectsUsersListRequestExpandItem(value);
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

    public static bool operator ==(ProjectsUsersListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ProjectsUsersListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ProjectsUsersListRequestExpandItem value) => value.Value;

    public static explicit operator ProjectsUsersListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Roles = "roles";

        public const string Teams = "teams";
    }
}
