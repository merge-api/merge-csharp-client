using System.Runtime.Serialization;

namespace Merge.Client.Ats;

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
