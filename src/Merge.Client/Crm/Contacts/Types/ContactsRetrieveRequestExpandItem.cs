using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<ContactsRetrieveRequestExpandItem>))]
public readonly record struct ContactsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly ContactsRetrieveRequestExpandItem Account = new(Values.Account);

    public static readonly ContactsRetrieveRequestExpandItem Owner = new(Values.Owner);

    public ContactsRetrieveRequestExpandItem(string value)
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
    public static ContactsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new ContactsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(ContactsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContactsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContactsRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator ContactsRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Account = "account";

        public const string Owner = "owner";
    }
}
