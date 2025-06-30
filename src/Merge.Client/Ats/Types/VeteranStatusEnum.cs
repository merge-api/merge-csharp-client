using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<VeteranStatusEnum>))]
[Serializable]
public readonly record struct VeteranStatusEnum : IStringEnum
{
    public static readonly VeteranStatusEnum IAmNotAProtectedVeteran = new(
        Values.IAmNotAProtectedVeteran
    );

    public static readonly VeteranStatusEnum IIdentifyAsOneOrMoreOfTheClassificationsOfAProtectedVeteran =
        new(Values.IIdentifyAsOneOrMoreOfTheClassificationsOfAProtectedVeteran);

    public static readonly VeteranStatusEnum IDontWishToAnswer = new(Values.IDontWishToAnswer);

    public VeteranStatusEnum(string value)
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
    public static VeteranStatusEnum FromCustom(string value)
    {
        return new VeteranStatusEnum(value);
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

    public static bool operator ==(VeteranStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VeteranStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VeteranStatusEnum value) => value.Value;

    public static explicit operator VeteranStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string IAmNotAProtectedVeteran = "I_AM_NOT_A_PROTECTED_VETERAN";

        public const string IIdentifyAsOneOrMoreOfTheClassificationsOfAProtectedVeteran =
            "I_IDENTIFY_AS_ONE_OR_MORE_OF_THE_CLASSIFICATIONS_OF_A_PROTECTED_VETERAN";

        public const string IDontWishToAnswer = "I_DONT_WISH_TO_ANSWER";
    }
}
