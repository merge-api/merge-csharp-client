using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffRetrieveRequestRemoteFields>))]
public readonly record struct TimeOffRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly TimeOffRetrieveRequestRemoteFields RequestType = new(Values.RequestType);

    public static readonly TimeOffRetrieveRequestRemoteFields RequestTypeStatus = new(
        Values.RequestTypeStatus
    );

    public static readonly TimeOffRetrieveRequestRemoteFields RequestTypeStatusUnits = new(
        Values.RequestTypeStatusUnits
    );

    public static readonly TimeOffRetrieveRequestRemoteFields RequestTypeUnits = new(
        Values.RequestTypeUnits
    );

    public static readonly TimeOffRetrieveRequestRemoteFields Status = new(Values.Status);

    public static readonly TimeOffRetrieveRequestRemoteFields StatusUnits = new(Values.StatusUnits);

    public static readonly TimeOffRetrieveRequestRemoteFields Units = new(Values.Units);

    public TimeOffRetrieveRequestRemoteFields(string value)
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
    public static TimeOffRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new TimeOffRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(TimeOffRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimeOffRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffRetrieveRequestRemoteFields value) => value.Value;

    public static explicit operator TimeOffRetrieveRequestRemoteFields(string value) => new(value);

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
