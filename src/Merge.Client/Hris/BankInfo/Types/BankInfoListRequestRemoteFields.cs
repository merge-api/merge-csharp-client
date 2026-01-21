using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<BankInfoListRequestRemoteFields>))]
[Serializable]
public readonly record struct BankInfoListRequestRemoteFields : IStringEnum
{
    public static readonly BankInfoListRequestRemoteFields AccountType = new(Values.AccountType);

    public BankInfoListRequestRemoteFields(string value)
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
    public static BankInfoListRequestRemoteFields FromCustom(string value)
    {
        return new BankInfoListRequestRemoteFields(value);
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

    public static bool operator ==(BankInfoListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BankInfoListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BankInfoListRequestRemoteFields value) => value.Value;

    public static explicit operator BankInfoListRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AccountType = "account_type";
    }
}
