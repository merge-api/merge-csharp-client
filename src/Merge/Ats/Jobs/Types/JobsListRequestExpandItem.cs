using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ats.Jobs;

[JsonConverter(typeof(StringEnumSerializer<JobsListRequestExpandItem>))]
public readonly record struct JobsListRequestExpandItem : IStringEnum
{
    public static readonly JobsListRequestExpandItem Departments = new(Values.Departments);

    public static readonly JobsListRequestExpandItem HiringManagers = new(Values.HiringManagers);

    public static readonly JobsListRequestExpandItem JobPostings = new(Values.JobPostings);

    public static readonly JobsListRequestExpandItem Offices = new(Values.Offices);

    public static readonly JobsListRequestExpandItem Recruiters = new(Values.Recruiters);

    public JobsListRequestExpandItem(string value)
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
    public static JobsListRequestExpandItem FromCustom(string value)
    {
        return new JobsListRequestExpandItem(value);
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

    public static bool operator ==(JobsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobsListRequestExpandItem value) => value.Value;

    public static explicit operator JobsListRequestExpandItem(string value) => new(value);

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
