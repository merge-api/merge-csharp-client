using System.Runtime.Serialization;

namespace Merge.Client.Ticketing;

public enum TicketsListRequestStatus
{
    [EnumMember(Value = "CLOSED")]
    Closed,

    [EnumMember(Value = "IN_PROGRESS")]
    InProgress,

    [EnumMember(Value = "ON_HOLD")]
    OnHold,

    [EnumMember(Value = "OPEN")]
    Open
}
