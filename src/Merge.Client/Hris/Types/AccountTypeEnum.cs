using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<AccountTypeEnum>))]
public readonly record struct AccountTypeEnum : IStringEnum
{
    public static readonly AccountTypeEnum Savings = new(Values.Savings);

    public static readonly AccountTypeEnum Checking = new(Values.Checking);

    public AccountTypeEnum(string value)
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
    public static AccountTypeEnum FromCustom(string value)
    {
        return new AccountTypeEnum(value);
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

    public static bool operator ==(AccountTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountTypeEnum value) => value.Value;

    public static explicit operator AccountTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Savings = "SAVINGS";

        public const string Checking = "CHECKING";
    }
}
