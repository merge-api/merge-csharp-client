using System.Runtime.Serialization;

namespace Merge.Client.Filestorage;

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
