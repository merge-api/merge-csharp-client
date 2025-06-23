using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<PayFrequencyEnum>))]
public readonly record struct PayFrequencyEnum : IStringEnum
{
    public static readonly PayFrequencyEnum Weekly = new(Values.Weekly);

    public static readonly PayFrequencyEnum Biweekly = new(Values.Biweekly);

    public static readonly PayFrequencyEnum Monthly = new(Values.Monthly);

    public static readonly PayFrequencyEnum Quarterly = new(Values.Quarterly);

    public static readonly PayFrequencyEnum Semiannually = new(Values.Semiannually);

    public static readonly PayFrequencyEnum Annually = new(Values.Annually);

    public static readonly PayFrequencyEnum ThirteenMonthly = new(Values.ThirteenMonthly);

    public static readonly PayFrequencyEnum ProRata = new(Values.ProRata);

    public static readonly PayFrequencyEnum Semimonthly = new(Values.Semimonthly);

    public PayFrequencyEnum(string value)
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
    public static PayFrequencyEnum FromCustom(string value)
    {
        return new PayFrequencyEnum(value);
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

    public static bool operator ==(PayFrequencyEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PayFrequencyEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PayFrequencyEnum value) => value.Value;

    public static explicit operator PayFrequencyEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Weekly = "WEEKLY";

        public const string Biweekly = "BIWEEKLY";

        public const string Monthly = "MONTHLY";

        public const string Quarterly = "QUARTERLY";

        public const string Semiannually = "SEMIANNUALLY";

        public const string Annually = "ANNUALLY";

        public const string ThirteenMonthly = "THIRTEEN-MONTHLY";

        public const string ProRata = "PRO_RATA";

        public const string Semimonthly = "SEMIMONTHLY";
    }
}
