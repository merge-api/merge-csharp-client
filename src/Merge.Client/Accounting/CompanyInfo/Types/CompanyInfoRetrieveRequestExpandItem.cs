using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<CompanyInfoRetrieveRequestExpandItem>))]
public enum CompanyInfoRetrieveRequestExpandItem
{
    [EnumMember(Value = "addresses")]
    Addresses,

    [EnumMember(Value = "phone_numbers")]
    PhoneNumbers,
}
