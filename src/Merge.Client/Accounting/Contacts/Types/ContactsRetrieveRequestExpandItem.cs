using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ContactsRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct ContactsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly ContactsRetrieveRequestExpandItem Addresses = new(Values.Addresses);

    public static readonly ContactsRetrieveRequestExpandItem Company = new(Values.Company);

    public static readonly ContactsRetrieveRequestExpandItem PhoneNumbers = new(
        Values.PhoneNumbers
    );

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
    [Serializable]
    public static class Values
    {
        public const string Addresses = "addresses";

        public const string Company = "company";

        public const string PhoneNumbers = "phone_numbers";
    }
}
