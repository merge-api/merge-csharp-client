using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

[JsonConverter(typeof(StringEnumSerializer<AccountDetailsAndActionsStatusEnum>))]
public enum AccountDetailsAndActionsStatusEnum
{
    [EnumMember(Value = "COMPLETE")]
    Complete,

    [EnumMember(Value = "INCOMPLETE")]
    Incomplete,

    [EnumMember(Value = "RELINK_NEEDED")]
    RelinkNeeded
}
