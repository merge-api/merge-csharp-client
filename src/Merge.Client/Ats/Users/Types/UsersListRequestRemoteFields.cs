using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<UsersListRequestRemoteFields>))]
[Serializable]
public readonly record struct UsersListRequestRemoteFields : IStringEnum
{
    public static readonly UsersListRequestRemoteFields AccessRole = new(Values.AccessRole);

    public UsersListRequestRemoteFields(string value)
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
    public static UsersListRequestRemoteFields FromCustom(string value)
    {
        return new UsersListRequestRemoteFields(value);
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

    public static bool operator ==(UsersListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UsersListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UsersListRequestRemoteFields value) => value.Value;

    public static explicit operator UsersListRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AccessRole = "access_role";
    }
}
