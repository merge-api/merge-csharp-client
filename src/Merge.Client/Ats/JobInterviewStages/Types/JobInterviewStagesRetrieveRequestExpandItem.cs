using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobInterviewStagesRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct JobInterviewStagesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly JobInterviewStagesRetrieveRequestExpandItem Job = new(Values.Job);

    public JobInterviewStagesRetrieveRequestExpandItem(string value)
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
    public static JobInterviewStagesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new JobInterviewStagesRetrieveRequestExpandItem(value);
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

    public static bool operator ==(
        JobInterviewStagesRetrieveRequestExpandItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        JobInterviewStagesRetrieveRequestExpandItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(JobInterviewStagesRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator JobInterviewStagesRetrieveRequestExpandItem(string value) =>
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
