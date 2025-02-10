using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<TasksListRequestExpand>))]
public enum TasksListRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,opportunity")]
    AccountOpportunity,

    [EnumMember(Value = "opportunity")]
    Opportunity,

    [EnumMember(Value = "owner")]
    Owner,

    [EnumMember(Value = "owner,account")]
    OwnerAccount,

    [EnumMember(Value = "owner,account,opportunity")]
    OwnerAccountOpportunity,

    [EnumMember(Value = "owner,opportunity")]
    OwnerOpportunity,
}
