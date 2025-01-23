using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<AsyncPostTaskStatusEnum>))]
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
