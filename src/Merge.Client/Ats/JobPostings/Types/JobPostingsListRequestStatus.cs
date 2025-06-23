using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobPostingsListRequestStatus>))]
public readonly record struct JobPostingsListRequestStatus : IStringEnum
{
    public static readonly JobPostingsListRequestStatus Closed = new(Values.Closed);

    public static readonly JobPostingsListRequestStatus Draft = new(Values.Draft);

    public static readonly JobPostingsListRequestStatus Internal = new(Values.Internal);

    public static readonly JobPostingsListRequestStatus Pending = new(Values.Pending);

    public static readonly JobPostingsListRequestStatus Published = new(Values.Published);

    public JobPostingsListRequestStatus(string value)
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
    public static JobPostingsListRequestStatus FromCustom(string value)
    {
        return new JobPostingsListRequestStatus(value);
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

    public static bool operator ==(JobPostingsListRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobPostingsListRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobPostingsListRequestStatus value) => value.Value;

    public static explicit operator JobPostingsListRequestStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Closed = "CLOSED";

        public const string Draft = "DRAFT";

        public const string Internal = "INTERNAL";

        public const string Pending = "PENDING";

        public const string Published = "PUBLISHED";
    }
}
