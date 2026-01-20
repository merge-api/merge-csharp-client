using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<AccountsRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct AccountsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly AccountsRetrieveRequestExpandItem Owner = new(Values.Owner);

    public AccountsRetrieveRequestExpandItem(string value)
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
    public static AccountsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new AccountsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(AccountsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator AccountsRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Owner = "owner";
    }
}
