using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<ContactsRetrieveRequestExpand>))]
public enum ContactsRetrieveRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,owner")]
    AccountOwner,

    [EnumMember(Value = "owner")]
    Owner
}
