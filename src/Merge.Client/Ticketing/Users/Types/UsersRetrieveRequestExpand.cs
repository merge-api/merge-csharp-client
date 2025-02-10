using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<UsersRetrieveRequestExpand>))]
public enum UsersRetrieveRequestExpand
{
    [EnumMember(Value = "roles")]
    Roles,

    [EnumMember(Value = "teams")]
    Teams,

    [EnumMember(Value = "teams,roles")]
    TeamsRoles,
}
