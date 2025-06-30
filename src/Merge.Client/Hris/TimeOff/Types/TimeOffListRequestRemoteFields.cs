using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffListRequestRemoteFields>))]
[Serializable]
public readonly record struct TimeOffListRequestRemoteFields : IStringEnum
{
    public static readonly TimeOffListRequestRemoteFields RequestType = new(Values.RequestType);

    public static readonly TimeOffListRequestRemoteFields RequestTypeStatus = new(
        Values.RequestTypeStatus
    );

    public static readonly TimeOffListRequestRemoteFields RequestTypeStatusUnits = new(
        Values.RequestTypeStatusUnits
    );

    public static readonly TimeOffListRequestRemoteFields RequestTypeUnits = new(
        Values.RequestTypeUnits
    );

    public static readonly TimeOffListRequestRemoteFields Status = new(Values.Status);

    public static readonly TimeOffListRequestRemoteFields StatusUnits = new(Values.StatusUnits);

    public static readonly TimeOffListRequestRemoteFields Units = new(Values.Units);

    public TimeOffListRequestRemoteFields(string value)
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
    public static TimeOffListRequestRemoteFields FromCustom(string value)
    {
        return new TimeOffListRequestRemoteFields(value);
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

    public static bool operator ==(TimeOffListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimeOffListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffListRequestRemoteFields value) => value.Value;

    public static explicit operator TimeOffListRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
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
