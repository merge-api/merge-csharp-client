using System.Runtime.Serialization;

namespace Merge.Client.Crm;

public enum AddressTypeEnum
{
    [EnumMember(Value = "BILLING")]
    Billing,

    [EnumMember(Value = "SHIPPING")]
    Shipping
}
