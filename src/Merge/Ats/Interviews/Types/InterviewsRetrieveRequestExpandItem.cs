using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ats.Interviews;

[JsonConverter(typeof(StringEnumSerializer<InterviewsRetrieveRequestExpandItem>))]
public readonly record struct InterviewsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly InterviewsRetrieveRequestExpandItem Application = new(
        Values.Application
    );

    public static readonly InterviewsRetrieveRequestExpandItem Interviewers = new(
        Values.Interviewers
    );

    public static readonly InterviewsRetrieveRequestExpandItem JobInterviewStage = new(
        Values.JobInterviewStage
    );

    public static readonly InterviewsRetrieveRequestExpandItem Organizer = new(Values.Organizer);

    public InterviewsRetrieveRequestExpandItem(string value)
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
    public static InterviewsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new InterviewsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(InterviewsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InterviewsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InterviewsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator InterviewsRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Application = "application";

        public const string Interviewers = "interviewers";

        public const string JobInterviewStage = "job_interview_stage";

        public const string Organizer = "organizer";
    }
}
