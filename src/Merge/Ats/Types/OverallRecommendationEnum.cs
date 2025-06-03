using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ats;

[JsonConverter(typeof(StringEnumSerializer<OverallRecommendationEnum>))]
public readonly record struct OverallRecommendationEnum : IStringEnum
{
    public static readonly OverallRecommendationEnum DefinitelyNo = new(Values.DefinitelyNo);

    public static readonly OverallRecommendationEnum No = new(Values.No);

    public static readonly OverallRecommendationEnum Yes = new(Values.Yes);

    public static readonly OverallRecommendationEnum StrongYes = new(Values.StrongYes);

    public static readonly OverallRecommendationEnum NoDecision = new(Values.NoDecision);

    public OverallRecommendationEnum(string value)
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
    public static OverallRecommendationEnum FromCustom(string value)
    {
        return new OverallRecommendationEnum(value);
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

    public static bool operator ==(OverallRecommendationEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OverallRecommendationEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OverallRecommendationEnum value) => value.Value;

    public static explicit operator OverallRecommendationEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string DefinitelyNo = "DEFINITELY_NO";

        public const string No = "NO";

        public const string Yes = "YES";

        public const string StrongYes = "STRONG_YES";

        public const string NoDecision = "NO_DECISION";
    }
}
