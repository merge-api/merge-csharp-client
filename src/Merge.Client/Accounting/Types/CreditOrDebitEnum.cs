using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CreditOrDebitEnum>))]
[Serializable]
public readonly record struct CreditOrDebitEnum : IStringEnum
{
    public static readonly CreditOrDebitEnum Credit = new(Values.Credit);

    public static readonly CreditOrDebitEnum Debit = new(Values.Debit);

    public CreditOrDebitEnum(string value)
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
    public static CreditOrDebitEnum FromCustom(string value)
    {
        return new CreditOrDebitEnum(value);
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

    public static bool operator ==(CreditOrDebitEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreditOrDebitEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreditOrDebitEnum value) => value.Value;

    public static explicit operator CreditOrDebitEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Credit = "CREDIT";

        public const string Debit = "DEBIT";
    }
}
