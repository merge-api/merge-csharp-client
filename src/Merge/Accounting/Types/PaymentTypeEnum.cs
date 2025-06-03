using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting;

[JsonConverter(typeof(StringEnumSerializer<PaymentTypeEnum>))]
public readonly record struct PaymentTypeEnum : IStringEnum
{
    public static readonly PaymentTypeEnum AccountsPayable = new(Values.AccountsPayable);

    public static readonly PaymentTypeEnum AccountsReceivable = new(Values.AccountsReceivable);

    public PaymentTypeEnum(string value)
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
    public static PaymentTypeEnum FromCustom(string value)
    {
        return new PaymentTypeEnum(value);
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

    public static bool operator ==(PaymentTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PaymentTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PaymentTypeEnum value) => value.Value;

    public static explicit operator PaymentTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string AccountsPayable = "ACCOUNTS_PAYABLE";

        public const string AccountsReceivable = "ACCOUNTS_RECEIVABLE";
    }
}
