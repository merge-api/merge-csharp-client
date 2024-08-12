using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<AccessRoleEnum>))]
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
