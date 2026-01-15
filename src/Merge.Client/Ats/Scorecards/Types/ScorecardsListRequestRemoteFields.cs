using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ScorecardsListRequestRemoteFields>))]
[Serializable]
public readonly record struct ScorecardsListRequestRemoteFields : IStringEnum
{
    public static readonly ScorecardsListRequestRemoteFields OverallRecommendation = new(
        Values.OverallRecommendation
    );

    public ScorecardsListRequestRemoteFields(string value)
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
    public static ScorecardsListRequestRemoteFields FromCustom(string value)
    {
        return new ScorecardsListRequestRemoteFields(value);
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

    public static bool operator ==(ScorecardsListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ScorecardsListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ScorecardsListRequestRemoteFields value) => value.Value;

    public static explicit operator ScorecardsListRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string OverallRecommendation = "overall_recommendation";
    }
}
