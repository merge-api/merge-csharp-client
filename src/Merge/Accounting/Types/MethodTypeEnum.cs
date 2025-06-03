using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting;

[JsonConverter(typeof(StringEnumSerializer<MethodTypeEnum>))]
public readonly record struct MethodTypeEnum : IStringEnum
{
    public static readonly MethodTypeEnum CreditCard = new(Values.CreditCard);

    public static readonly MethodTypeEnum DebitCard = new(Values.DebitCard);

    public static readonly MethodTypeEnum Ach = new(Values.Ach);

    public static readonly MethodTypeEnum Cash = new(Values.Cash);

    public static readonly MethodTypeEnum Check = new(Values.Check);

    public MethodTypeEnum(string value)
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
    public static MethodTypeEnum FromCustom(string value)
    {
        return new MethodTypeEnum(value);
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

    public static bool operator ==(MethodTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MethodTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MethodTypeEnum value) => value.Value;

    public static explicit operator MethodTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string CreditCard = "CREDIT_CARD";

        public const string DebitCard = "DEBIT_CARD";

        public const string Ach = "ACH";

        public const string Cash = "CASH";

        public const string Check = "CHECK";
    }
}
