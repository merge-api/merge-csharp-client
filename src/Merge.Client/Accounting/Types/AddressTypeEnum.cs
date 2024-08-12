using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<AddressTypeEnum>))]
public enum AddressTypeEnum
{
    [EnumMember(Value = "BILLING")]
    Billing,

    [EnumMember(Value = "SHIPPING")]
    Shipping
}
