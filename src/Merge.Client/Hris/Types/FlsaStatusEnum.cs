using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<FlsaStatusEnum>))]
public readonly record struct FlsaStatusEnum : IStringEnum
{
    public static readonly FlsaStatusEnum Exempt = new(Values.Exempt);

    public static readonly FlsaStatusEnum SalariedNonexempt = new(Values.SalariedNonexempt);

    public static readonly FlsaStatusEnum Nonexempt = new(Values.Nonexempt);

    public static readonly FlsaStatusEnum Owner = new(Values.Owner);

    public FlsaStatusEnum(string value)
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
    public static FlsaStatusEnum FromCustom(string value)
    {
        return new FlsaStatusEnum(value);
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

    public static bool operator ==(FlsaStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FlsaStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FlsaStatusEnum value) => value.Value;

    public static explicit operator FlsaStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Exempt = "EXEMPT";

        public const string SalariedNonexempt = "SALARIED_NONEXEMPT";

        public const string Nonexempt = "NONEXEMPT";

        public const string Owner = "OWNER";
    }
}
