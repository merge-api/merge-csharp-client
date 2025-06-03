using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris.TimeOff;

[JsonConverter(typeof(StringEnumSerializer<TimeOffListRequestShowEnumOrigins>))]
public readonly record struct TimeOffListRequestShowEnumOrigins : IStringEnum
{
    public static readonly TimeOffListRequestShowEnumOrigins RequestType = new(Values.RequestType);

    public static readonly TimeOffListRequestShowEnumOrigins RequestTypeStatus = new(
        Values.RequestTypeStatus
    );

    public static readonly TimeOffListRequestShowEnumOrigins RequestTypeStatusUnits = new(
        Values.RequestTypeStatusUnits
    );

    public static readonly TimeOffListRequestShowEnumOrigins RequestTypeUnits = new(
        Values.RequestTypeUnits
    );

    public static readonly TimeOffListRequestShowEnumOrigins Status = new(Values.Status);

    public static readonly TimeOffListRequestShowEnumOrigins StatusUnits = new(Values.StatusUnits);

    public static readonly TimeOffListRequestShowEnumOrigins Units = new(Values.Units);

    public TimeOffListRequestShowEnumOrigins(string value)
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
    public static TimeOffListRequestShowEnumOrigins FromCustom(string value)
    {
        return new TimeOffListRequestShowEnumOrigins(value);
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

    public static bool operator ==(TimeOffListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimeOffListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffListRequestShowEnumOrigins value) => value.Value;

    public static explicit operator TimeOffListRequestShowEnumOrigins(string value) => new(value);

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
