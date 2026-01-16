using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ScorecardsListRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct ScorecardsListRequestShowEnumOrigins : IStringEnum
{
    public static readonly ScorecardsListRequestShowEnumOrigins OverallRecommendation = new(
        Values.OverallRecommendation
    );

    public ScorecardsListRequestShowEnumOrigins(string value)
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
    public static ScorecardsListRequestShowEnumOrigins FromCustom(string value)
    {
        return new ScorecardsListRequestShowEnumOrigins(value);
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

    public static bool operator ==(ScorecardsListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ScorecardsListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ScorecardsListRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator ScorecardsListRequestShowEnumOrigins(string value) =>
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
