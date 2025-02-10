using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<OpportunitiesListRequestExpand>))]
public enum OpportunitiesListRequestExpand
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
