using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public enum ContactsRetrieveRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,owner")]
    AccountOwner,

    [EnumMember(Value = "owner")]
    Owner
}
