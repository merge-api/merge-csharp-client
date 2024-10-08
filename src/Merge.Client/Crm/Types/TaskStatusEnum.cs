using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<TaskStatusEnum>))]
public enum TaskStatusEnum
{
    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "CLOSED")]
    Closed,
}
