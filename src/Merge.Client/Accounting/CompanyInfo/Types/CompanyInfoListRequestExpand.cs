using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum CompanyInfoListRequestExpand
{
    [EnumMember(Value = "addresses")]
    Addresses,

    [EnumMember(Value = "addresses,phone_numbers")]
    AddressesPhoneNumbers,

    [EnumMember(Value = "phone_numbers")]
    PhoneNumbers
}
