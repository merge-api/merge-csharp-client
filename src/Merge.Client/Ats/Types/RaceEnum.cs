using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<RaceEnum>))]
[Serializable]
public readonly record struct RaceEnum : IStringEnum
{
    public static readonly RaceEnum AmericanIndianOrAlaskanNative = new(
        Values.AmericanIndianOrAlaskanNative
    );

    public static readonly RaceEnum Asian = new(Values.Asian);

    public static readonly RaceEnum BlackOrAfricanAmerican = new(Values.BlackOrAfricanAmerican);

    public static readonly RaceEnum HispanicOrLatino = new(Values.HispanicOrLatino);

    public static readonly RaceEnum White = new(Values.White);

    public static readonly RaceEnum NativeHawaiianOrOtherPacificIslander = new(
        Values.NativeHawaiianOrOtherPacificIslander
    );

    public static readonly RaceEnum TwoOrMoreRaces = new(Values.TwoOrMoreRaces);

    public static readonly RaceEnum DeclineToSelfIdentify = new(Values.DeclineToSelfIdentify);

    public RaceEnum(string value)
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
    public static RaceEnum FromCustom(string value)
    {
        return new RaceEnum(value);
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

    public static bool operator ==(RaceEnum value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(RaceEnum value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(RaceEnum value) => value.Value;

    public static explicit operator RaceEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AmericanIndianOrAlaskanNative = "AMERICAN_INDIAN_OR_ALASKAN_NATIVE";

        public const string Asian = "ASIAN";

        public const string BlackOrAfricanAmerican = "BLACK_OR_AFRICAN_AMERICAN";

        public const string HispanicOrLatino = "HISPANIC_OR_LATINO";

        public const string White = "WHITE";

        public const string NativeHawaiianOrOtherPacificIslander =
            "NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER";

        public const string TwoOrMoreRaces = "TWO_OR_MORE_RACES";

        public const string DeclineToSelfIdentify = "DECLINE_TO_SELF_IDENTIFY";
    }
}
