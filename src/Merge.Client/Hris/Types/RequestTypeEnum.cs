using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<RequestTypeEnum>))]
public readonly record struct RequestTypeEnum : IStringEnum
{
    public static readonly RequestTypeEnum Vacation = new(Values.Vacation);

    public static readonly RequestTypeEnum Sick = new(Values.Sick);

    public static readonly RequestTypeEnum Personal = new(Values.Personal);

    public static readonly RequestTypeEnum JuryDuty = new(Values.JuryDuty);

    public static readonly RequestTypeEnum Volunteer = new(Values.Volunteer);

    public static readonly RequestTypeEnum Bereavement = new(Values.Bereavement);

    public RequestTypeEnum(string value)
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
    public static RequestTypeEnum FromCustom(string value)
    {
        return new RequestTypeEnum(value);
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

    public static bool operator ==(RequestTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RequestTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RequestTypeEnum value) => value.Value;

    public static explicit operator RequestTypeEnum(string value) => new(value);

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
