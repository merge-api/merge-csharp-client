using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EarningTypeEnum>))]
[Serializable]
public readonly record struct EarningTypeEnum : IStringEnum
{
    public static readonly EarningTypeEnum Salary = new(Values.Salary);

    public static readonly EarningTypeEnum Reimbursement = new(Values.Reimbursement);

    public static readonly EarningTypeEnum Overtime = new(Values.Overtime);

    public static readonly EarningTypeEnum Bonus = new(Values.Bonus);

    public EarningTypeEnum(string value)
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
    public static EarningTypeEnum FromCustom(string value)
    {
        return new EarningTypeEnum(value);
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

    public static bool operator ==(EarningTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EarningTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EarningTypeEnum value) => value.Value;

    public static explicit operator EarningTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Salary = "SALARY";

        public const string Reimbursement = "REIMBURSEMENT";

        public const string Overtime = "OVERTIME";

        public const string Bonus = "BONUS";
    }
}
