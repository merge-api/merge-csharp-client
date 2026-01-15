using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<BankInfoRetrieveRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct BankInfoRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly BankInfoRetrieveRequestShowEnumOrigins AccountType = new(
        Values.AccountType
    );

    public BankInfoRetrieveRequestShowEnumOrigins(string value)
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
    public static BankInfoRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new BankInfoRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(BankInfoRetrieveRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BankInfoRetrieveRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BankInfoRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator BankInfoRetrieveRequestShowEnumOrigins(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AccountType = "account_type";
    }
}
