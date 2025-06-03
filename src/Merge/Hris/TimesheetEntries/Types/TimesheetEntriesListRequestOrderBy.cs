using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris.TimesheetEntries;

[JsonConverter(typeof(StringEnumSerializer<TimesheetEntriesListRequestOrderBy>))]
public readonly record struct TimesheetEntriesListRequestOrderBy : IStringEnum
{
    public static readonly TimesheetEntriesListRequestOrderBy StartTimeDescending = new(
        Values.StartTimeDescending
    );

    public static readonly TimesheetEntriesListRequestOrderBy StartTimeAscending = new(
        Values.StartTimeAscending
    );

    public TimesheetEntriesListRequestOrderBy(string value)
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
    public static TimesheetEntriesListRequestOrderBy FromCustom(string value)
    {
        return new TimesheetEntriesListRequestOrderBy(value);
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

    public static bool operator ==(TimesheetEntriesListRequestOrderBy value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimesheetEntriesListRequestOrderBy value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimesheetEntriesListRequestOrderBy value) => value.Value;

    public static explicit operator TimesheetEntriesListRequestOrderBy(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string StartTimeDescending = "-start_time";

        public const string StartTimeAscending = "start_time";
    }
}
