using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<TicketAccessEnum>))]
public enum TicketAccessEnum
{
    [EnumMember(Value = "ALL")]
    All,

    [EnumMember(Value = "ASSIGNED_ONLY")]
    AssignedOnly,

    [EnumMember(Value = "TEAM_ONLY")]
    TeamOnly,
}
