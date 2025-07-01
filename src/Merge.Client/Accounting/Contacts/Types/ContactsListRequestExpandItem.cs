using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ContactsListRequestExpandItem>))]
[Serializable]
public readonly record struct ContactsListRequestExpandItem : IStringEnum
{
    public static readonly ContactsListRequestExpandItem Addresses = new(Values.Addresses);

    public static readonly ContactsListRequestExpandItem Company = new(Values.Company);

    public static readonly ContactsListRequestExpandItem PhoneNumbers = new(Values.PhoneNumbers);

    public ContactsListRequestExpandItem(string value)
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
    public static ContactsListRequestExpandItem FromCustom(string value)
    {
        return new ContactsListRequestExpandItem(value);
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

    public static bool operator ==(ContactsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContactsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContactsListRequestExpandItem value) => value.Value;

    public static explicit operator ContactsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Addresses = "addresses";

        public const string Company = "company";

        public const string PhoneNumbers = "phone_numbers";
    }
}
