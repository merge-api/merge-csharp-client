using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<PurchaseOrderStatusEnum>))]
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
    Deleted,
}
