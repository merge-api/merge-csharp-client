using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<ContactsListRequestExpand>))]
public enum ContactsListRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,owner")]
    AccountOwner,

    [EnumMember(Value = "owner")]
    Owner,
}
