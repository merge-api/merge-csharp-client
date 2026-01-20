using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ContactsListRequestStatus>))]
[Serializable]
public readonly record struct ContactsListRequestStatus : IStringEnum
{
    public static readonly ContactsListRequestStatus Empty = new(Values.Empty);

    public static readonly ContactsListRequestStatus Active = new(Values.Active);

    public static readonly ContactsListRequestStatus Archived = new(Values.Archived);

    public ContactsListRequestStatus(string value)
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
    public static ContactsListRequestStatus FromCustom(string value)
    {
        return new ContactsListRequestStatus(value);
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

    public static bool operator ==(ContactsListRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContactsListRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContactsListRequestStatus value) => value.Value;

    public static explicit operator ContactsListRequestStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Empty = "";

        public const string Active = "ACTIVE";

        public const string Archived = "ARCHIVED";
    }
}
