using System.Runtime.Serialization;

namespace Merge.Client.Crm;

public enum NotesListRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,opportunity")]
    AccountOpportunity,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "contact,account")]
    ContactAccount,

    [EnumMember(Value = "contact,account,opportunity")]
    ContactAccountOpportunity,

    [EnumMember(Value = "contact,opportunity")]
    ContactOpportunity,

    [EnumMember(Value = "opportunity")]
    Opportunity,

    [EnumMember(Value = "owner")]
    Owner,

    [EnumMember(Value = "owner,account")]
    OwnerAccount,

    [EnumMember(Value = "owner,account,opportunity")]
    OwnerAccountOpportunity,

    [EnumMember(Value = "owner,contact")]
    OwnerContact,

    [EnumMember(Value = "owner,contact,account")]
    OwnerContactAccount,

    [EnumMember(Value = "owner,contact,account,opportunity")]
    OwnerContactAccountOpportunity,

    [EnumMember(Value = "owner,contact,opportunity")]
    OwnerContactOpportunity,

    [EnumMember(Value = "owner,opportunity")]
    OwnerOpportunity
}
