using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<TicketsListRequestShowEnumOrigins>))]
public enum TicketsListRequestShowEnumOrigins
{
    [EnumMember(Value = "priority")]
    Priority,

    [EnumMember(Value = "priority,status")]
    PriorityStatus,

    [EnumMember(Value = "priority,status,ticket_type")]
    PriorityStatusTicketType,

    [EnumMember(Value = "priority,ticket_type")]
    PriorityTicketType,

    [EnumMember(Value = "status")]
    Status,

    [EnumMember(Value = "status,ticket_type")]
    StatusTicketType,

    [EnumMember(Value = "ticket_type")]
    TicketType
}
