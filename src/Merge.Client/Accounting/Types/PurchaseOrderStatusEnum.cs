using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Accounting;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<PurchaseOrderStatusEnum>))]
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
