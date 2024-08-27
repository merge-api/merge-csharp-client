using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<OpportunitiesRetrieveRequestExpand>))]
public enum OpportunitiesRetrieveRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "owner")]
    Owner,

    [EnumMember(Value = "owner,account")]
    OwnerAccount,

    [EnumMember(Value = "owner,stage")]
    OwnerStage,

    [EnumMember(Value = "owner,stage,account")]
    OwnerStageAccount,

    [EnumMember(Value = "stage")]
    Stage,

    [EnumMember(Value = "stage,account")]
    StageAccount,
}
