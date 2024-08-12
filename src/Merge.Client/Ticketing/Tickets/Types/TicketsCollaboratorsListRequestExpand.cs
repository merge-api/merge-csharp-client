using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<TicketsCollaboratorsListRequestExpand>))]
public enum TicketsCollaboratorsListRequestExpand
{
    [EnumMember(Value = "roles")]
    Roles,

    [EnumMember(Value = "teams")]
    Teams,

    [EnumMember(Value = "teams,roles")]
    TeamsRoles
}
