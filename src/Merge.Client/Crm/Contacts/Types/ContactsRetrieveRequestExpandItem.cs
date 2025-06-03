using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<ContactsRetrieveRequestExpandItem>))]
public enum ContactsRetrieveRequestExpandItem
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "owner")]
    Owner,
}
