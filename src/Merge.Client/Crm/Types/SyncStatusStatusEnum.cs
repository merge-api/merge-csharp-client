using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<SyncStatusStatusEnum>))]
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
    PartiallySynced,
}
