using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Filestorage;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum AccountDetailsAndActionsStatusEnum
{
    [EnumMember(Value = "COMPLETE")]
    Complete,

    [EnumMember(Value = "INCOMPLETE")]
    Incomplete,

    [EnumMember(Value = "RELINK_NEEDED")]
    RelinkNeeded
}
