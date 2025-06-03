using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris;

[JsonConverter(typeof(StringEnumSerializer<PolicyTypeEnum>))]
public readonly record struct PolicyTypeEnum : IStringEnum
{
    public static readonly PolicyTypeEnum Vacation = new(Values.Vacation);

    public static readonly PolicyTypeEnum Sick = new(Values.Sick);

    public static readonly PolicyTypeEnum Personal = new(Values.Personal);

    public static readonly PolicyTypeEnum JuryDuty = new(Values.JuryDuty);

    public static readonly PolicyTypeEnum Volunteer = new(Values.Volunteer);

    public static readonly PolicyTypeEnum Bereavement = new(Values.Bereavement);

    public PolicyTypeEnum(string value)
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
    public static PolicyTypeEnum FromCustom(string value)
    {
        return new PolicyTypeEnum(value);
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

    public static bool operator ==(PolicyTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PolicyTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PolicyTypeEnum value) => value.Value;

    public static explicit operator PolicyTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Vacation = "VACATION";

        public const string Sick = "SICK";

        public const string Personal = "PERSONAL";

        public const string JuryDuty = "JURY_DUTY";

        public const string Volunteer = "VOLUNTEER";

        public const string Bereavement = "BEREAVEMENT";
    }
}
