using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<RaceEnum>))]
public enum RaceEnum
{
    [EnumMember(Value = "AMERICAN_INDIAN_OR_ALASKAN_NATIVE")]
    AmericanIndianOrAlaskanNative,

    [EnumMember(Value = "ASIAN")]
    Asian,

    [EnumMember(Value = "BLACK_OR_AFRICAN_AMERICAN")]
    BlackOrAfricanAmerican,

    [EnumMember(Value = "HISPANIC_OR_LATINO")]
    HispanicOrLatino,

    [EnumMember(Value = "WHITE")]
    White,

    [EnumMember(Value = "NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER")]
    NativeHawaiianOrOtherPacificIslander,

    [EnumMember(Value = "TWO_OR_MORE_RACES")]
    TwoOrMoreRaces,

    [EnumMember(Value = "DECLINE_TO_SELF_IDENTIFY")]
    DeclineToSelfIdentify,
}
