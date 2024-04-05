using System.Runtime.Serialization;

namespace Merge.Client.Crm;

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
    StageAccount
}
