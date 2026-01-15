using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ContactsListRequestRemoteFields>))]
[Serializable]
public readonly record struct ContactsListRequestRemoteFields : IStringEnum
{
    public static readonly ContactsListRequestRemoteFields Status = new(Values.Status);

    public ContactsListRequestRemoteFields(string value)
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
    public static ContactsListRequestRemoteFields FromCustom(string value)
    {
        return new ContactsListRequestRemoteFields(value);
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

    public static bool operator ==(ContactsListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContactsListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContactsListRequestRemoteFields value) => value.Value;

    public static explicit operator ContactsListRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Status = "status";
    }
}
