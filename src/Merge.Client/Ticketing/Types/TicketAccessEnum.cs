using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<TicketAccessEnum>))]
public enum TicketAccessEnum
{
    [EnumMember(Value = "ALL")]
    All,

    [EnumMember(Value = "ASSIGNED_ONLY")]
    AssignedOnly,

    [EnumMember(Value = "TEAM_ONLY")]
    TeamOnly
}
