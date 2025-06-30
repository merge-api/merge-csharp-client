using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<DisabilityStatusEnum>))]
[Serializable]
public readonly record struct DisabilityStatusEnum : IStringEnum
{
    public static readonly DisabilityStatusEnum YesIHaveADisabilityOrPreviouslyHadADisability = new(
        Values.YesIHaveADisabilityOrPreviouslyHadADisability
    );

    public static readonly DisabilityStatusEnum NoIDontHaveADisability = new(
        Values.NoIDontHaveADisability
    );

    public static readonly DisabilityStatusEnum IDontWishToAnswer = new(Values.IDontWishToAnswer);

    public DisabilityStatusEnum(string value)
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
    public static DisabilityStatusEnum FromCustom(string value)
    {
        return new DisabilityStatusEnum(value);
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

    public static bool operator ==(DisabilityStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DisabilityStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DisabilityStatusEnum value) => value.Value;

    public static explicit operator DisabilityStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string YesIHaveADisabilityOrPreviouslyHadADisability =
            "YES_I_HAVE_A_DISABILITY_OR_PREVIOUSLY_HAD_A_DISABILITY";

        public const string NoIDontHaveADisability = "NO_I_DONT_HAVE_A_DISABILITY";

        public const string IDontWishToAnswer = "I_DONT_WISH_TO_ANSWER";
    }
}
