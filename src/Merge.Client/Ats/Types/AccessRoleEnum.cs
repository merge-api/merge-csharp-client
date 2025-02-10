using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<AccessRoleEnum>))]
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
    Interviewer,
}
