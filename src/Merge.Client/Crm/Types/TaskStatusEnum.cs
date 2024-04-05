using System.Runtime.Serialization;

namespace Merge.Client.Crm;

public enum TaskStatusEnum
{
    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "CLOSED")]
    Closed
}
