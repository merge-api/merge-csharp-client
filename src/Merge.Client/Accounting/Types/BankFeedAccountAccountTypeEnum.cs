using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<BankFeedAccountAccountTypeEnum>))]
public readonly record struct BankFeedAccountAccountTypeEnum : IStringEnum
{
    public static readonly BankFeedAccountAccountTypeEnum Bank = new(Values.Bank);

    public static readonly BankFeedAccountAccountTypeEnum CreditCard = new(Values.CreditCard);

    public BankFeedAccountAccountTypeEnum(string value)
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
    public static BankFeedAccountAccountTypeEnum FromCustom(string value)
    {
        return new BankFeedAccountAccountTypeEnum(value);
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

    public static bool operator ==(BankFeedAccountAccountTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BankFeedAccountAccountTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BankFeedAccountAccountTypeEnum value) => value.Value;

    public static explicit operator BankFeedAccountAccountTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Bank = "BANK";

        public const string CreditCard = "CREDIT_CARD";
    }
}
