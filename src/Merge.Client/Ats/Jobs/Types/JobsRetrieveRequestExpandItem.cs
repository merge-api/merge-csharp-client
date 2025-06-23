using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobsRetrieveRequestExpandItem>))]
public readonly record struct JobsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly JobsRetrieveRequestExpandItem Departments = new(Values.Departments);

    public static readonly JobsRetrieveRequestExpandItem HiringManagers = new(
        Values.HiringManagers
    );

    public static readonly JobsRetrieveRequestExpandItem JobPostings = new(Values.JobPostings);

    public static readonly JobsRetrieveRequestExpandItem Offices = new(Values.Offices);

    public static readonly JobsRetrieveRequestExpandItem Recruiters = new(Values.Recruiters);

    public JobsRetrieveRequestExpandItem(string value)
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
    public static JobsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new JobsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(JobsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobsRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator JobsRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Departments = "departments";

        public const string HiringManagers = "hiring_managers";

        public const string JobPostings = "job_postings";

        public const string Offices = "offices";

        public const string Recruiters = "recruiters";
    }
}
