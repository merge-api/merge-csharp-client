using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public enum TicketAccessEnum
{
    [EnumMember(Value = "ALL")]
    All,

    [EnumMember(Value = "ASSIGNED_ONLY")]
    AssignedOnly,

    [EnumMember(Value = "TEAM_ONLY")]
    TeamOnly
}
