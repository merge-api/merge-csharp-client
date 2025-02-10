using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<PriorityEnum>))]
public enum PriorityEnum
{
    [EnumMember(Value = "URGENT")]
    Urgent,

    [EnumMember(Value = "HIGH")]
    High,

    [EnumMember(Value = "NORMAL")]
    Normal,

    [EnumMember(Value = "LOW")]
    Low,
}
