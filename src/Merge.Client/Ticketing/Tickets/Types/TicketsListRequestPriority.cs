using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum TicketsListRequestPriority
{
    [EnumMember(Value = "HIGH")]
    High,

    [EnumMember(Value = "LOW")]
    Low,

    [EnumMember(Value = "NORMAL")]
    Normal,

    [EnumMember(Value = "URGENT")]
    Urgent
}
