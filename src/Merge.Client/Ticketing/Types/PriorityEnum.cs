using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum PriorityEnum
{
    [EnumMember(Value = "URGENT")]
    Urgent,

    [EnumMember(Value = "HIGH")]
    High,

    [EnumMember(Value = "NORMAL")]
    Normal,

    [EnumMember(Value = "LOW")]
    Low
}
