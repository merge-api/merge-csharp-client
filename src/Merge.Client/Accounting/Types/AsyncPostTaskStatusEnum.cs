using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<AsyncPostTaskStatusEnum>))]
public enum AsyncPostTaskStatusEnum
{
    [EnumMember(Value = "QUEUED")]
    Queued,

    [EnumMember(Value = "IN_PROGRESS")]
    InProgress,

    [EnumMember(Value = "COMPLETED")]
    Completed,

    [EnumMember(Value = "FAILURE")]
    Failure,
}
