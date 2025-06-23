using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffStatusEnum>))]
public readonly record struct TimeOffStatusEnum : IStringEnum
{
    public static readonly TimeOffStatusEnum Requested = new(Values.Requested);

    public static readonly TimeOffStatusEnum Approved = new(Values.Approved);

    public static readonly TimeOffStatusEnum Declined = new(Values.Declined);

    public static readonly TimeOffStatusEnum Cancelled = new(Values.Cancelled);

    public static readonly TimeOffStatusEnum Deleted = new(Values.Deleted);

    public TimeOffStatusEnum(string value)
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
    public static TimeOffStatusEnum FromCustom(string value)
    {
        return new TimeOffStatusEnum(value);
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

    public static bool operator ==(TimeOffStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimeOffStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimeOffStatusEnum value) => value.Value;

    public static explicit operator TimeOffStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Requested = "REQUESTED";

        public const string Approved = "APPROVED";

        public const string Declined = "DECLINED";

        public const string Cancelled = "CANCELLED";

        public const string Deleted = "DELETED";
    }
}
