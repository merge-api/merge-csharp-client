using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum PurchaseOrderStatusEnum
{
    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "SUBMITTED")]
    Submitted,

    [EnumMember(Value = "AUTHORIZED")]
    Authorized,

    [EnumMember(Value = "BILLED")]
    Billed,

    [EnumMember(Value = "DELETED")]
    Deleted
}
