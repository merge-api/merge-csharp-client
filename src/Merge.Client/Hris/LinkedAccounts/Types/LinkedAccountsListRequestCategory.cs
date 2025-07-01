using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<LinkedAccountsListRequestCategory>))]
[Serializable]
public readonly record struct LinkedAccountsListRequestCategory : IStringEnum
{
    public static readonly LinkedAccountsListRequestCategory Accounting = new(Values.Accounting);

    public static readonly LinkedAccountsListRequestCategory Ats = new(Values.Ats);

    public static readonly LinkedAccountsListRequestCategory Crm = new(Values.Crm);

    public static readonly LinkedAccountsListRequestCategory Filestorage = new(Values.Filestorage);

    public static readonly LinkedAccountsListRequestCategory Hris = new(Values.Hris);

    public static readonly LinkedAccountsListRequestCategory Mktg = new(Values.Mktg);

    public static readonly LinkedAccountsListRequestCategory Ticketing = new(Values.Ticketing);

    public LinkedAccountsListRequestCategory(string value)
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
    public static LinkedAccountsListRequestCategory FromCustom(string value)
    {
        return new LinkedAccountsListRequestCategory(value);
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

    public static bool operator ==(LinkedAccountsListRequestCategory value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LinkedAccountsListRequestCategory value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LinkedAccountsListRequestCategory value) => value.Value;

    public static explicit operator LinkedAccountsListRequestCategory(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Accounting = "accounting";

        public const string Ats = "ats";

        public const string Crm = "crm";

        public const string Filestorage = "filestorage";

        public const string Hris = "hris";

        public const string Mktg = "mktg";

        public const string Ticketing = "ticketing";
    }
}
