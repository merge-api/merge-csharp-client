using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public enum UsersRetrieveRequestExpand
{
    [EnumMember(Value = "roles")]
    Roles,

    [EnumMember(Value = "teams")]
    Teams,

    [EnumMember(Value = "teams,roles")]
    TeamsRoles
}
