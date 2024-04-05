using System.Runtime.Serialization;

namespace Merge.Client.Ticketing;

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
