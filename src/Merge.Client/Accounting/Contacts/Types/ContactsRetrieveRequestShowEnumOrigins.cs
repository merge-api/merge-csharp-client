using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ContactsRetrieveRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct ContactsRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly ContactsRetrieveRequestShowEnumOrigins Status = new(Values.Status);

    public ContactsRetrieveRequestShowEnumOrigins(string value)
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
    public static ContactsRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new ContactsRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(ContactsRetrieveRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContactsRetrieveRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContactsRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator ContactsRetrieveRequestShowEnumOrigins(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Status = "status";
    }
}
