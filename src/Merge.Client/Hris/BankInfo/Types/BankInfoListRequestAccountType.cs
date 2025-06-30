using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<BankInfoListRequestAccountType>))]
[Serializable]
public readonly record struct BankInfoListRequestAccountType : IStringEnum
{
    public static readonly BankInfoListRequestAccountType Checking = new(Values.Checking);

    public static readonly BankInfoListRequestAccountType Savings = new(Values.Savings);

    public BankInfoListRequestAccountType(string value)
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
    public static BankInfoListRequestAccountType FromCustom(string value)
    {
        return new BankInfoListRequestAccountType(value);
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

    public static bool operator ==(BankInfoListRequestAccountType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BankInfoListRequestAccountType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BankInfoListRequestAccountType value) => value.Value;

    public static explicit operator BankInfoListRequestAccountType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Checking = "CHECKING";

        public const string Savings = "SAVINGS";
    }
}
