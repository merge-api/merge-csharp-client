using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<PurchaseOrdersRetrieveRequestExpandItem>))]
public enum PurchaseOrdersRetrieveRequestExpandItem
{
    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "delivery_address")]
    DeliveryAddress,

    [EnumMember(Value = "line_items")]
    LineItems,

    [EnumMember(Value = "payment_term")]
    PaymentTerm,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,

    [EnumMember(Value = "vendor")]
    Vendor,
}
