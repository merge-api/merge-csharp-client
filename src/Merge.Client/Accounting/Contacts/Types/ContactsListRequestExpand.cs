using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum ContactsListRequestExpand
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
