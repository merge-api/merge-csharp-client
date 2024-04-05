using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum EthnicityEnum
{
    [EnumMember(Value = "AMERICAN_INDIAN_OR_ALASKA_NATIVE")]
    AmericanIndianOrAlaskaNative,

    [EnumMember(Value = "ASIAN_OR_INDIAN_SUBCONTINENT")]
    AsianOrIndianSubcontinent,

    [EnumMember(Value = "BLACK_OR_AFRICAN_AMERICAN")]
    BlackOrAfricanAmerican,

    [EnumMember(Value = "HISPANIC_OR_LATINO")]
    HispanicOrLatino,

    [EnumMember(Value = "NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER")]
    NativeHawaiianOrOtherPacificIslander,

    [EnumMember(Value = "TWO_OR_MORE_RACES")]
    TwoOrMoreRaces,

    [EnumMember(Value = "WHITE")]
    White,

    [EnumMember(Value = "PREFER_NOT_TO_DISCLOSE")]
    PreferNotToDisclose
}
