using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum EeocsListRequestShowEnumOrigins
{
    [EnumMember(Value = "disability_status")]
    DisabilityStatus,

    [EnumMember(Value = "disability_status,gender")]
    DisabilityStatusGender,

    [EnumMember(Value = "disability_status,gender,race")]
    DisabilityStatusGenderRace,

    [EnumMember(Value = "disability_status,gender,race,veteran_status")]
    DisabilityStatusGenderRaceVeteranStatus,

    [EnumMember(Value = "disability_status,gender,veteran_status")]
    DisabilityStatusGenderVeteranStatus,

    [EnumMember(Value = "disability_status,race")]
    DisabilityStatusRace,

    [EnumMember(Value = "disability_status,race,veteran_status")]
    DisabilityStatusRaceVeteranStatus,

    [EnumMember(Value = "disability_status,veteran_status")]
    DisabilityStatusVeteranStatus,

    [EnumMember(Value = "gender")]
    Gender,

    [EnumMember(Value = "gender,race")]
    GenderRace,

    [EnumMember(Value = "gender,race,veteran_status")]
    GenderRaceVeteranStatus,

    [EnumMember(Value = "gender,veteran_status")]
    GenderVeteranStatus,

    [EnumMember(Value = "race")]
    Race,

    [EnumMember(Value = "race,veteran_status")]
    RaceVeteranStatus,

    [EnumMember(Value = "veteran_status")]
    VeteranStatus
}
