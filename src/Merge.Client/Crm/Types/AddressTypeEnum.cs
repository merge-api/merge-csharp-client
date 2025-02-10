using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<AddressTypeEnum>))]
public enum AddressTypeEnum
{
    [EnumMember(Value = "BILLING")]
    Billing,

    [EnumMember(Value = "SHIPPING")]
    Shipping,
}
