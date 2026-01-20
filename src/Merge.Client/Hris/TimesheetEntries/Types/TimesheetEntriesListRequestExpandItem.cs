using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimesheetEntriesListRequestExpandItem>))]
[Serializable]
public readonly record struct TimesheetEntriesListRequestExpandItem : IStringEnum
{
    public static readonly TimesheetEntriesListRequestExpandItem Employee = new(Values.Employee);

    public TimesheetEntriesListRequestExpandItem(string value)
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
    public static TimesheetEntriesListRequestExpandItem FromCustom(string value)
    {
        return new TimesheetEntriesListRequestExpandItem(value);
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

    public static bool operator ==(TimesheetEntriesListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimesheetEntriesListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimesheetEntriesListRequestExpandItem value) =>
        value.Value;

    public static explicit operator TimesheetEntriesListRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Employee = "employee";
    }
}
