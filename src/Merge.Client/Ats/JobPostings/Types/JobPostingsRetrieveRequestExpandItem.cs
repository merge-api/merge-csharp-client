using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobPostingsRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct JobPostingsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly JobPostingsRetrieveRequestExpandItem Job = new(Values.Job);

    public JobPostingsRetrieveRequestExpandItem(string value)
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
    public static JobPostingsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new JobPostingsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(JobPostingsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobPostingsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobPostingsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator JobPostingsRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Job = "job";
    }
}
