using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<TasksRetrieveRequestExpand>))]
public enum TasksRetrieveRequestExpand
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
    OwnerOpportunity
}
