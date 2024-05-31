using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Accounting;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ContactsRetrieveRequestExpand>))]
public enum ContactsRetrieveRequestExpand
{
    [EnumMember(Value = "addresses")]
    Addresses,

    [EnumMember(Value = "addresses,company")]
    AddressesCompany,

    [EnumMember(Value = "addresses,phone_numbers")]
    AddressesPhoneNumbers,

    [EnumMember(Value = "addresses,phone_numbers,company")]
    AddressesPhoneNumbersCompany,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "phone_numbers")]
    PhoneNumbers,

    [EnumMember(Value = "phone_numbers,company")]
    PhoneNumbersCompany
}
