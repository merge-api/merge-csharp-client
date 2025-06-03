using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris.TimeOff;

[JsonConverter(typeof(StringEnumSerializer<TimeOffRetrieveRequestExpandItem>))]
public readonly record struct TimeOffRetrieveRequestExpandItem : IStringEnum
{
    public static readonly TimeOffRetrieveRequestExpandItem Approver = new(Values.Approver);

    public static readonly TimeOffRetrieveRequestExpandItem Employee = new(Values.Employee);

    public TimeOffRetrieveRequestExpandItem(string value)
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
    public static TimeOffRetrieveRequestExpandItem FromCustom(string value)
    {
        return new TimeOffRetrieveRequestExpandItem(value);
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

    public static bool operator ==(TimeOffRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimeOffRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator TimeOffRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Approver = "approver";

        public const string Employee = "employee";
    }
}
