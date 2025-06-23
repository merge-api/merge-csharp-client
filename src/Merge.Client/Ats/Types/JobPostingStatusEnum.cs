using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobPostingStatusEnum>))]
public readonly record struct JobPostingStatusEnum : IStringEnum
{
    public static readonly JobPostingStatusEnum Published = new(Values.Published);

    public static readonly JobPostingStatusEnum Closed = new(Values.Closed);

    public static readonly JobPostingStatusEnum Draft = new(Values.Draft);

    public static readonly JobPostingStatusEnum Internal = new(Values.Internal);

    public static readonly JobPostingStatusEnum Pending = new(Values.Pending);

    public JobPostingStatusEnum(string value)
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
    public static JobPostingStatusEnum FromCustom(string value)
    {
        return new JobPostingStatusEnum(value);
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

    public static bool operator ==(JobPostingStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobPostingStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobPostingStatusEnum value) => value.Value;

    public static explicit operator JobPostingStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Published = "PUBLISHED";

        public const string Closed = "CLOSED";

        public const string Draft = "DRAFT";

        public const string Internal = "INTERNAL";

        public const string Pending = "PENDING";
    }
}
