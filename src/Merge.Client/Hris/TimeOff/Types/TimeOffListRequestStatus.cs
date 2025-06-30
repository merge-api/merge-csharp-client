using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffListRequestStatus>))]
[Serializable]
public readonly record struct TimeOffListRequestStatus : IStringEnum
{
    public static readonly TimeOffListRequestStatus Approved = new(Values.Approved);

    public static readonly TimeOffListRequestStatus Cancelled = new(Values.Cancelled);

    public static readonly TimeOffListRequestStatus Declined = new(Values.Declined);

    public static readonly TimeOffListRequestStatus Deleted = new(Values.Deleted);

    public static readonly TimeOffListRequestStatus Requested = new(Values.Requested);

    public TimeOffListRequestStatus(string value)
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
    public static TimeOffListRequestStatus FromCustom(string value)
    {
        return new TimeOffListRequestStatus(value);
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

    public static bool operator ==(TimeOffListRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimeOffListRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffListRequestStatus value) => value.Value;

    public static explicit operator TimeOffListRequestStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Approved = "APPROVED";

        public const string Cancelled = "CANCELLED";

        public const string Declined = "DECLINED";

        public const string Deleted = "DELETED";

        public const string Requested = "REQUESTED";
    }
}
