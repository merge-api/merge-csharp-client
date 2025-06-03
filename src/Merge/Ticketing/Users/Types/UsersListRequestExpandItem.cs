using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing.Users;

[JsonConverter(typeof(StringEnumSerializer<UsersListRequestExpandItem>))]
public readonly record struct UsersListRequestExpandItem : IStringEnum
{
    public static readonly UsersListRequestExpandItem Roles = new(Values.Roles);

    public static readonly UsersListRequestExpandItem Teams = new(Values.Teams);

    public UsersListRequestExpandItem(string value)
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
    public static UsersListRequestExpandItem FromCustom(string value)
    {
        return new UsersListRequestExpandItem(value);
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

    public static bool operator ==(UsersListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UsersListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UsersListRequestExpandItem value) => value.Value;

    public static explicit operator UsersListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Roles = "roles";

        public const string Teams = "teams";
    }
}
