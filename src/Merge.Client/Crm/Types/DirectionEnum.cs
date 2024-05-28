using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public enum DirectionEnum
{
    [EnumMember(Value = "INBOUND")]
    Inbound,

    [EnumMember(Value = "OUTBOUND")]
    Outbound
}
