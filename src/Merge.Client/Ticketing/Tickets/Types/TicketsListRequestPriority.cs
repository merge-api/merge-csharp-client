using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

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
