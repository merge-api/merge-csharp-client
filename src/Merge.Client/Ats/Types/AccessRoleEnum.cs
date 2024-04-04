using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum AccessRoleEnum
{
    [EnumMember(Value = "SUPER_ADMIN")]
    SuperAdmin,

    [EnumMember(Value = "ADMIN")]
    Admin,

    [EnumMember(Value = "TEAM_MEMBER")]
    TeamMember,

    [EnumMember(Value = "LIMITED_TEAM_MEMBER")]
    LimitedTeamMember,

    [EnumMember(Value = "INTERVIEWER")]
    Interviewer
}
