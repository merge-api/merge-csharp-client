using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
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
