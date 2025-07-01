using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<LeadsRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct LeadsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly LeadsRetrieveRequestExpandItem ConvertedAccount = new(
        Values.ConvertedAccount
    );

    public static readonly LeadsRetrieveRequestExpandItem ConvertedContact = new(
        Values.ConvertedContact
    );

    public static readonly LeadsRetrieveRequestExpandItem Owner = new(Values.Owner);

    public LeadsRetrieveRequestExpandItem(string value)
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
    public static LeadsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new LeadsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(LeadsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LeadsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LeadsRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator LeadsRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ConvertedAccount = "converted_account";

        public const string ConvertedContact = "converted_contact";

        public const string Owner = "owner";
    }
}
