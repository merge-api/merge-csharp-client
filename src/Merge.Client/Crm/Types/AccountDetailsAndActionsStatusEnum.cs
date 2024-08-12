using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

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
