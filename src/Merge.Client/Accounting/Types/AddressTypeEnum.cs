using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum AddressTypeEnum
{
    [EnumMember(Value = "BILLING")]
    Billing,

    [EnumMember(Value = "SHIPPING")]
    Shipping
}
