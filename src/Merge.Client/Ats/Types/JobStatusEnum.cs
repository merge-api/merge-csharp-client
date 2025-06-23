using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobStatusEnum>))]
public readonly record struct JobStatusEnum : IStringEnum
{
    public static readonly JobStatusEnum Open = new(Values.Open);

    public static readonly JobStatusEnum Closed = new(Values.Closed);

    public static readonly JobStatusEnum Draft = new(Values.Draft);

    public static readonly JobStatusEnum Archived = new(Values.Archived);

    public static readonly JobStatusEnum Pending = new(Values.Pending);

    public JobStatusEnum(string value)
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
    public static JobStatusEnum FromCustom(string value)
    {
        return new JobStatusEnum(value);
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

    public static bool operator ==(JobStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobStatusEnum value) => value.Value;

    public static explicit operator JobStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Open = "OPEN";

        public const string Closed = "CLOSED";

        public const string Draft = "DRAFT";

        public const string Archived = "ARCHIVED";

        public const string Pending = "PENDING";
    }
}
