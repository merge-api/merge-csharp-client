using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<TicketsListRequestPriority>))]
public enum TicketsListRequestPriority
{
    [EnumMember(Value = "HIGH")]
    High,

    [EnumMember(Value = "LOW")]
    Low,

    [EnumMember(Value = "NORMAL")]
    Normal,

    [EnumMember(Value = "URGENT")]
    Urgent,
}
