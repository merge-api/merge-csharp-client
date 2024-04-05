using System.Runtime.Serialization;

namespace Merge.Client.Ticketing;

public enum ProjectsUsersListRequestExpand
{
    [EnumMember(Value = "roles")]
    Roles,

    [EnumMember(Value = "teams")]
    Teams,

    [EnumMember(Value = "teams,roles")]
    TeamsRoles
}
