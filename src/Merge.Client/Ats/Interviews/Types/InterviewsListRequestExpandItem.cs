using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<InterviewsListRequestExpandItem>))]
[Serializable]
public readonly record struct InterviewsListRequestExpandItem : IStringEnum
{
    public static readonly InterviewsListRequestExpandItem Application = new(Values.Application);

    public static readonly InterviewsListRequestExpandItem Interviewers = new(Values.Interviewers);

    public static readonly InterviewsListRequestExpandItem JobInterviewStage = new(
        Values.JobInterviewStage
    );

    public static readonly InterviewsListRequestExpandItem Organizer = new(Values.Organizer);

    public InterviewsListRequestExpandItem(string value)
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
    public static InterviewsListRequestExpandItem FromCustom(string value)
    {
        return new InterviewsListRequestExpandItem(value);
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

    public static bool operator ==(InterviewsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InterviewsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InterviewsListRequestExpandItem value) => value.Value;

    public static explicit operator InterviewsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Application = "application";

        public const string Interviewers = "interviewers";

        public const string JobInterviewStage = "job_interview_stage";

        public const string Organizer = "organizer";
    }
}
