using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<TicketStatusEnum>))]
public enum TicketStatusEnum
{
    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "CLOSED")]
    Closed,

    [EnumMember(Value = "IN_PROGRESS")]
    InProgress,

    [EnumMember(Value = "ON_HOLD")]
    OnHold,
}
