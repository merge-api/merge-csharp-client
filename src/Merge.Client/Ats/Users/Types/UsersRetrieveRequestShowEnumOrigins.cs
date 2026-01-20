using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<UsersRetrieveRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct UsersRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly UsersRetrieveRequestShowEnumOrigins AccessRole = new(Values.AccessRole);

    public UsersRetrieveRequestShowEnumOrigins(string value)
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
    public static UsersRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new UsersRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(UsersRetrieveRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UsersRetrieveRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UsersRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator UsersRetrieveRequestShowEnumOrigins(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AccessRole = "access_role";
    }
}
