using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm.Leads;

[JsonConverter(typeof(StringEnumSerializer<LeadsListRequestExpandItem>))]
public readonly record struct LeadsListRequestExpandItem : IStringEnum
{
    public static readonly LeadsListRequestExpandItem ConvertedAccount = new(
        Values.ConvertedAccount
    );

    public static readonly LeadsListRequestExpandItem ConvertedContact = new(
        Values.ConvertedContact
    );

    public static readonly LeadsListRequestExpandItem Owner = new(Values.Owner);

    public LeadsListRequestExpandItem(string value)
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
    public static LeadsListRequestExpandItem FromCustom(string value)
    {
        return new LeadsListRequestExpandItem(value);
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

    public static bool operator ==(LeadsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LeadsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LeadsListRequestExpandItem value) => value.Value;

    public static explicit operator LeadsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string ConvertedAccount = "converted_account";

        public const string ConvertedContact = "converted_contact";

        public const string Owner = "owner";
    }
}
