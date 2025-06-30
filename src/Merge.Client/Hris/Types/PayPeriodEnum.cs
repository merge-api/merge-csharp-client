using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<PayPeriodEnum>))]
[Serializable]
public readonly record struct PayPeriodEnum : IStringEnum
{
    public static readonly PayPeriodEnum Hour = new(Values.Hour);

    public static readonly PayPeriodEnum Day = new(Values.Day);

    public static readonly PayPeriodEnum Week = new(Values.Week);

    public static readonly PayPeriodEnum EveryTwoWeeks = new(Values.EveryTwoWeeks);

    public static readonly PayPeriodEnum Semimonthly = new(Values.Semimonthly);

    public static readonly PayPeriodEnum Month = new(Values.Month);

    public static readonly PayPeriodEnum Quarter = new(Values.Quarter);

    public static readonly PayPeriodEnum EverySixMonths = new(Values.EverySixMonths);

    public static readonly PayPeriodEnum Year = new(Values.Year);

    public PayPeriodEnum(string value)
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
    public static PayPeriodEnum FromCustom(string value)
    {
        return new PayPeriodEnum(value);
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

    public static bool operator ==(PayPeriodEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PayPeriodEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PayPeriodEnum value) => value.Value;

    public static explicit operator PayPeriodEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Hour = "HOUR";

        public const string Day = "DAY";

        public const string Week = "WEEK";

        public const string EveryTwoWeeks = "EVERY_TWO_WEEKS";

        public const string Semimonthly = "SEMIMONTHLY";

        public const string Month = "MONTH";

        public const string Quarter = "QUARTER";

        public const string EverySixMonths = "EVERY_SIX_MONTHS";

        public const string Year = "YEAR";
    }
}
