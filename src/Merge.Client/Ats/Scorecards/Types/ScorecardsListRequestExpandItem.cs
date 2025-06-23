using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ScorecardsListRequestExpandItem>))]
public readonly record struct ScorecardsListRequestExpandItem : IStringEnum
{
    public static readonly ScorecardsListRequestExpandItem Application = new(Values.Application);

    public static readonly ScorecardsListRequestExpandItem Interview = new(Values.Interview);

    public static readonly ScorecardsListRequestExpandItem Interviewer = new(Values.Interviewer);

    public ScorecardsListRequestExpandItem(string value)
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
    public static ScorecardsListRequestExpandItem FromCustom(string value)
    {
        return new ScorecardsListRequestExpandItem(value);
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

    public static bool operator ==(ScorecardsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ScorecardsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ScorecardsListRequestExpandItem value) => value.Value;

    public static explicit operator ScorecardsListRequestExpandItem(string value) => new(value);

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
