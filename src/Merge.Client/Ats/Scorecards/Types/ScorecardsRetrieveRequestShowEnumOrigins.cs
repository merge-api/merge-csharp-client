using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ScorecardsRetrieveRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct ScorecardsRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly ScorecardsRetrieveRequestShowEnumOrigins OverallRecommendation = new(
        Values.OverallRecommendation
    );

    public ScorecardsRetrieveRequestShowEnumOrigins(string value)
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
    public static ScorecardsRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new ScorecardsRetrieveRequestShowEnumOrigins(value);
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
        ScorecardsRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ScorecardsRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ScorecardsRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator ScorecardsRetrieveRequestShowEnumOrigins(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string OverallRecommendation = "overall_recommendation";
    }
}
