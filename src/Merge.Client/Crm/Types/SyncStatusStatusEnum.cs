using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public enum SyncStatusStatusEnum
{
    [EnumMember(Value = "SYNCING")]
    Syncing,

    [EnumMember(Value = "DONE")]
    Done,

    [EnumMember(Value = "FAILED")]
    Failed,

    [EnumMember(Value = "DISABLED")]
    Disabled,

    [EnumMember(Value = "PAUSED")]
    Paused,

    [EnumMember(Value = "PARTIALLY_SYNCED")]
    PartiallySynced
}
