using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffListRequestRequestType>))]
public readonly record struct TimeOffListRequestRequestType : IStringEnum
{
    public static readonly TimeOffListRequestRequestType Bereavement = new(Values.Bereavement);

    public static readonly TimeOffListRequestRequestType JuryDuty = new(Values.JuryDuty);

    public static readonly TimeOffListRequestRequestType Personal = new(Values.Personal);

    public static readonly TimeOffListRequestRequestType Sick = new(Values.Sick);

    public static readonly TimeOffListRequestRequestType Vacation = new(Values.Vacation);

    public static readonly TimeOffListRequestRequestType Volunteer = new(Values.Volunteer);

    public TimeOffListRequestRequestType(string value)
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
    public static TimeOffListRequestRequestType FromCustom(string value)
    {
        return new TimeOffListRequestRequestType(value);
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

    public static bool operator ==(TimeOffListRequestRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimeOffListRequestRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffListRequestRequestType value) => value.Value;

    public static explicit operator TimeOffListRequestRequestType(string value) => new(value);

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
