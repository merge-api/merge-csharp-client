using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<MaritalStatusEnum>))]
public readonly record struct MaritalStatusEnum : IStringEnum
{
    public static readonly MaritalStatusEnum Single = new(Values.Single);

    public static readonly MaritalStatusEnum MarriedFilingJointly = new(
        Values.MarriedFilingJointly
    );

    public static readonly MaritalStatusEnum MarriedFilingSeparately = new(
        Values.MarriedFilingSeparately
    );

    public static readonly MaritalStatusEnum HeadOfHousehold = new(Values.HeadOfHousehold);

    public static readonly MaritalStatusEnum QualifyingWidowOrWidowerWithDependentChild = new(
        Values.QualifyingWidowOrWidowerWithDependentChild
    );

    public MaritalStatusEnum(string value)
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
    public static MaritalStatusEnum FromCustom(string value)
    {
        return new MaritalStatusEnum(value);
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

    public static bool operator ==(MaritalStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MaritalStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MaritalStatusEnum value) => value.Value;

    public static explicit operator MaritalStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Single = "SINGLE";

        public const string MarriedFilingJointly = "MARRIED_FILING_JOINTLY";

        public const string MarriedFilingSeparately = "MARRIED_FILING_SEPARATELY";

        public const string HeadOfHousehold = "HEAD_OF_HOUSEHOLD";

        public const string QualifyingWidowOrWidowerWithDependentChild =
            "QUALIFYING_WIDOW_OR_WIDOWER_WITH_DEPENDENT_CHILD";
    }
}
