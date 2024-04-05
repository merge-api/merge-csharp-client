using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Crm;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum ContactsListRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,owner")]
    AccountOwner,

    [EnumMember(Value = "owner")]
    Owner
}
