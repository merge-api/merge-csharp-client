using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum SelectiveSyncConfigurationsUsageEnum
{
    [EnumMember(Value = "IN_NEXT_SYNC")]
    InNextSync,

    [EnumMember(Value = "IN_LAST_SYNC")]
    InLastSync
}
