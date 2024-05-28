using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public enum TaskStatusEnum
{
    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "CLOSED")]
    Closed
}
