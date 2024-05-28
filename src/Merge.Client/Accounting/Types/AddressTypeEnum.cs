using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum AddressTypeEnum
{
    [EnumMember(Value = "BILLING")]
    Billing,

    [EnumMember(Value = "SHIPPING")]
    Shipping
}
