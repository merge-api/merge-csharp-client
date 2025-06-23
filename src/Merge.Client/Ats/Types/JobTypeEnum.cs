using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobTypeEnum>))]
public readonly record struct JobTypeEnum : IStringEnum
{
    public static readonly JobTypeEnum Posting = new(Values.Posting);

    public static readonly JobTypeEnum Requisition = new(Values.Requisition);

    public static readonly JobTypeEnum Profile = new(Values.Profile);

    public JobTypeEnum(string value)
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
    public static JobTypeEnum FromCustom(string value)
    {
        return new JobTypeEnum(value);
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

    public static bool operator ==(JobTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobTypeEnum value) => value.Value;

    public static explicit operator JobTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Posting = "POSTING";

        public const string Requisition = "REQUISITION";

        public const string Profile = "PROFILE";
    }
}
