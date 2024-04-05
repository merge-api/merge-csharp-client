using System.Runtime.Serialization;

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
