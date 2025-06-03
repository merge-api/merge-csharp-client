using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<ContactsListRequestExpandItem>))]
public enum ContactsListRequestExpandItem
{
    [EnumMember(Value = "addresses")]
    Addresses,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "phone_numbers")]
    PhoneNumbers,
}
