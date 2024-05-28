using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Crm;

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
