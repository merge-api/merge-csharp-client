using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(TolerantEnumConverter))]
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
