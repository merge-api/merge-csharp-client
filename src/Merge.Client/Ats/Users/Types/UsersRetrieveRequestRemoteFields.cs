using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<UsersRetrieveRequestRemoteFields>))]
[Serializable]
public readonly record struct UsersRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly UsersRetrieveRequestRemoteFields AccessRole = new(Values.AccessRole);

    public UsersRetrieveRequestRemoteFields(string value)
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
    public static UsersRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new UsersRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(UsersRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UsersRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UsersRetrieveRequestRemoteFields value) => value.Value;

    public static explicit operator UsersRetrieveRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AccessRole = "access_role";
    }
}
