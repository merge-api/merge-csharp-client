using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris.TimeOff;

[JsonConverter(typeof(StringEnumSerializer<TimeOffRetrieveRequestShowEnumOrigins>))]
public readonly record struct TimeOffRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly TimeOffRetrieveRequestShowEnumOrigins RequestType = new(
        Values.RequestType
    );

    public static readonly TimeOffRetrieveRequestShowEnumOrigins RequestTypeStatus = new(
        Values.RequestTypeStatus
    );

    public static readonly TimeOffRetrieveRequestShowEnumOrigins RequestTypeStatusUnits = new(
        Values.RequestTypeStatusUnits
    );

    public static readonly TimeOffRetrieveRequestShowEnumOrigins RequestTypeUnits = new(
        Values.RequestTypeUnits
    );

    public static readonly TimeOffRetrieveRequestShowEnumOrigins Status = new(Values.Status);

    public static readonly TimeOffRetrieveRequestShowEnumOrigins StatusUnits = new(
        Values.StatusUnits
    );

    public static readonly TimeOffRetrieveRequestShowEnumOrigins Units = new(Values.Units);

    public TimeOffRetrieveRequestShowEnumOrigins(string value)
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
    public static TimeOffRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new TimeOffRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(TimeOffRetrieveRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimeOffRetrieveRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator TimeOffRetrieveRequestShowEnumOrigins(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string RequestType = "request_type";

        public const string RequestTypeStatus = "request_type,status";

        public const string RequestTypeStatusUnits = "request_type,status,units";

        public const string RequestTypeUnits = "request_type,units";

        public const string Status = "status";

        public const string StatusUnits = "status,units";

        public const string Units = "units";
    }
}
