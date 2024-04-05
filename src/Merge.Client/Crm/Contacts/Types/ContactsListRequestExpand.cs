using System.Runtime.Serialization;

namespace Merge.Client.Crm;

public enum ContactsListRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,owner")]
    AccountOwner,

    [EnumMember(Value = "owner")]
    Owner
}
