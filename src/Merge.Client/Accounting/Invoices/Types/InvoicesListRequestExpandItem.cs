using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<InvoicesListRequestExpandItem>))]
public enum InvoicesListRequestExpandItem
{
    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "applied_credit_notes")]
    AppliedCreditNotes,

    [EnumMember(Value = "applied_payments")]
    AppliedPayments,

    [EnumMember(Value = "applied_vendor_credits")]
    AppliedVendorCredits,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "line_items")]
    LineItems,

    [EnumMember(Value = "payment_term")]
    PaymentTerm,

    [EnumMember(Value = "payments")]
    Payments,

    [EnumMember(Value = "purchase_orders")]
    PurchaseOrders,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,
}
