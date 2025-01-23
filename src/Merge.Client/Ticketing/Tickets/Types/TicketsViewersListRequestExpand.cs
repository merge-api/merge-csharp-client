using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<TicketsViewersListRequestExpand>))]
public enum TicketsViewersListRequestExpand
{
    [EnumMember(Value = "team")]
    Team,

    [EnumMember(Value = "user")]
    User,

    [EnumMember(Value = "user,team")]
    UserTeam,
}
