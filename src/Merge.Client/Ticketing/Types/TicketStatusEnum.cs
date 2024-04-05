using System.Runtime.Serialization;

namespace Merge.Client.Ticketing;

public enum TicketStatusEnum
{
    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "CLOSED")]
    Closed,

    [EnumMember(Value = "IN_PROGRESS")]
    InProgress,

    [EnumMember(Value = "ON_HOLD")]
    OnHold
}
