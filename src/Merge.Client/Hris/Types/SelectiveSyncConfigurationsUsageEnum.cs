using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<SelectiveSyncConfigurationsUsageEnum>))]
public enum SelectiveSyncConfigurationsUsageEnum
{
    [EnumMember(Value = "IN_NEXT_SYNC")]
    InNextSync,

    [EnumMember(Value = "IN_LAST_SYNC")]
    InLastSync,
}
