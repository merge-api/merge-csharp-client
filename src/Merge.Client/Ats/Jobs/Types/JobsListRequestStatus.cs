using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobsListRequestStatus>))]
public readonly record struct JobsListRequestStatus : IStringEnum
{
    public static readonly JobsListRequestStatus Archived = new(Values.Archived);

    public static readonly JobsListRequestStatus Closed = new(Values.Closed);

    public static readonly JobsListRequestStatus Draft = new(Values.Draft);

    public static readonly JobsListRequestStatus Open = new(Values.Open);

    public static readonly JobsListRequestStatus Pending = new(Values.Pending);

    public JobsListRequestStatus(string value)
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
    public static JobsListRequestStatus FromCustom(string value)
    {
        return new JobsListRequestStatus(value);
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

    public static bool operator ==(JobsListRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobsListRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobsListRequestStatus value) => value.Value;

    public static explicit operator JobsListRequestStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Archived = "ARCHIVED";

        public const string Closed = "CLOSED";

        public const string Draft = "DRAFT";

        public const string Open = "OPEN";

        public const string Pending = "PENDING";
    }
}
