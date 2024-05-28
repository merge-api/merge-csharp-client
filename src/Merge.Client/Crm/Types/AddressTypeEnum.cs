using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public enum AddressTypeEnum
{
    [EnumMember(Value = "BILLING")]
    Billing,

    [EnumMember(Value = "SHIPPING")]
    Shipping
}
