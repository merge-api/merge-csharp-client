using System.Runtime.Serialization;

namespace Merge.Client.Crm;

public enum DirectionEnum
{
    [EnumMember(Value = "INBOUND")]
    Inbound,

    [EnumMember(Value = "OUTBOUND")]
    Outbound
}
