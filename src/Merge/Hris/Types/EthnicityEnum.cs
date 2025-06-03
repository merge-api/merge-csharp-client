using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris;

[JsonConverter(typeof(StringEnumSerializer<EthnicityEnum>))]
public readonly record struct EthnicityEnum : IStringEnum
{
    public static readonly EthnicityEnum AmericanIndianOrAlaskaNative = new(
        Values.AmericanIndianOrAlaskaNative
    );

    public static readonly EthnicityEnum AsianOrIndianSubcontinent = new(
        Values.AsianOrIndianSubcontinent
    );

    public static readonly EthnicityEnum BlackOrAfricanAmerican = new(
        Values.BlackOrAfricanAmerican
    );

    public static readonly EthnicityEnum HispanicOrLatino = new(Values.HispanicOrLatino);

    public static readonly EthnicityEnum NativeHawaiianOrOtherPacificIslander = new(
        Values.NativeHawaiianOrOtherPacificIslander
    );

    public static readonly EthnicityEnum TwoOrMoreRaces = new(Values.TwoOrMoreRaces);

    public static readonly EthnicityEnum White = new(Values.White);

    public static readonly EthnicityEnum PreferNotToDisclose = new(Values.PreferNotToDisclose);

    public EthnicityEnum(string value)
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
    public static EthnicityEnum FromCustom(string value)
    {
        return new EthnicityEnum(value);
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

    public static bool operator ==(EthnicityEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EthnicityEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EthnicityEnum value) => value.Value;

    public static explicit operator EthnicityEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string AmericanIndianOrAlaskaNative = "AMERICAN_INDIAN_OR_ALASKA_NATIVE";

        public const string AsianOrIndianSubcontinent = "ASIAN_OR_INDIAN_SUBCONTINENT";

        public const string BlackOrAfricanAmerican = "BLACK_OR_AFRICAN_AMERICAN";

        public const string HispanicOrLatino = "HISPANIC_OR_LATINO";

        public const string NativeHawaiianOrOtherPacificIslander =
            "NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER";

        public const string TwoOrMoreRaces = "TWO_OR_MORE_RACES";

        public const string White = "WHITE";

        public const string PreferNotToDisclose = "PREFER_NOT_TO_DISCLOSE";
    }
}
