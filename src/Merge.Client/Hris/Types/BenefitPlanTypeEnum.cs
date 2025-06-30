using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<BenefitPlanTypeEnum>))]
[Serializable]
public readonly record struct BenefitPlanTypeEnum : IStringEnum
{
    public static readonly BenefitPlanTypeEnum Medical = new(Values.Medical);

    public static readonly BenefitPlanTypeEnum HealthSavings = new(Values.HealthSavings);

    public static readonly BenefitPlanTypeEnum Insurance = new(Values.Insurance);

    public static readonly BenefitPlanTypeEnum Retirement = new(Values.Retirement);

    public static readonly BenefitPlanTypeEnum Other = new(Values.Other);

    public BenefitPlanTypeEnum(string value)
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
    public static BenefitPlanTypeEnum FromCustom(string value)
    {
        return new BenefitPlanTypeEnum(value);
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

    public static bool operator ==(BenefitPlanTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BenefitPlanTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BenefitPlanTypeEnum value) => value.Value;

    public static explicit operator BenefitPlanTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Medical = "MEDICAL";

        public const string HealthSavings = "HEALTH_SAVINGS";

        public const string Insurance = "INSURANCE";

        public const string Retirement = "RETIREMENT";

        public const string Other = "OTHER";
    }
}
