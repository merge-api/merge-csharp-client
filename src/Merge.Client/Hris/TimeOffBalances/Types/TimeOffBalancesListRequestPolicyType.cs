using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffBalancesListRequestPolicyType>))]
public readonly record struct TimeOffBalancesListRequestPolicyType : IStringEnum
{
    public static readonly TimeOffBalancesListRequestPolicyType Bereavement = new(
        Values.Bereavement
    );

    public static readonly TimeOffBalancesListRequestPolicyType JuryDuty = new(Values.JuryDuty);

    public static readonly TimeOffBalancesListRequestPolicyType Personal = new(Values.Personal);

    public static readonly TimeOffBalancesListRequestPolicyType Sick = new(Values.Sick);

    public static readonly TimeOffBalancesListRequestPolicyType Vacation = new(Values.Vacation);

    public static readonly TimeOffBalancesListRequestPolicyType Volunteer = new(Values.Volunteer);

    public TimeOffBalancesListRequestPolicyType(string value)
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
    public static TimeOffBalancesListRequestPolicyType FromCustom(string value)
    {
        return new TimeOffBalancesListRequestPolicyType(value);
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

    public static bool operator ==(TimeOffBalancesListRequestPolicyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimeOffBalancesListRequestPolicyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffBalancesListRequestPolicyType value) =>
        value.Value;

    public static explicit operator TimeOffBalancesListRequestPolicyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Bereavement = "BEREAVEMENT";

        public const string JuryDuty = "JURY_DUTY";

        public const string Personal = "PERSONAL";

        public const string Sick = "SICK";

        public const string Vacation = "VACATION";

        public const string Volunteer = "VOLUNTEER";
    }
}
