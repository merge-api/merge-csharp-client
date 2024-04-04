using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Crm;

[JsonConverter(typeof(TolerantEnumConverter))]
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
