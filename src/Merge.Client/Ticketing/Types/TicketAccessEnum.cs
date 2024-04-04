using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum TicketAccessEnum
{
    [EnumMember(Value = "ALL")]
    All,

    [EnumMember(Value = "ASSIGNED_ONLY")]
    AssignedOnly,

    [EnumMember(Value = "TEAM_ONLY")]
    TeamOnly
}
