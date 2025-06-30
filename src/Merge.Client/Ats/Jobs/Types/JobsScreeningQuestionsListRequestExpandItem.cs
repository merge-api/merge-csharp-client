using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobsScreeningQuestionsListRequestExpandItem>))]
[Serializable]
public readonly record struct JobsScreeningQuestionsListRequestExpandItem : IStringEnum
{
    public static readonly JobsScreeningQuestionsListRequestExpandItem Job = new(Values.Job);

    public static readonly JobsScreeningQuestionsListRequestExpandItem Options = new(
        Values.Options
    );

    public JobsScreeningQuestionsListRequestExpandItem(string value)
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
    public static JobsScreeningQuestionsListRequestExpandItem FromCustom(string value)
    {
        return new JobsScreeningQuestionsListRequestExpandItem(value);
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
        JobsScreeningQuestionsListRequestExpandItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        JobsScreeningQuestionsListRequestExpandItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(JobsScreeningQuestionsListRequestExpandItem value) =>
        value.Value;

    public static explicit operator JobsScreeningQuestionsListRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Job = "job";

        public const string Options = "options";
    }
}
