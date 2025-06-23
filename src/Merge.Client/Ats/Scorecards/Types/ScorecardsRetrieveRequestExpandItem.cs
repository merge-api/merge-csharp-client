using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ScorecardsRetrieveRequestExpandItem>))]
public readonly record struct ScorecardsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly ScorecardsRetrieveRequestExpandItem Application = new(
        Values.Application
    );

    public static readonly ScorecardsRetrieveRequestExpandItem Interview = new(Values.Interview);

    public static readonly ScorecardsRetrieveRequestExpandItem Interviewer = new(
        Values.Interviewer
    );

    public ScorecardsRetrieveRequestExpandItem(string value)
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
    public static ScorecardsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new ScorecardsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(ScorecardsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ScorecardsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ScorecardsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator ScorecardsRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Application = "application";

        public const string Interview = "interview";

        public const string Interviewer = "interviewer";
    }
}
