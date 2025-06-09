using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<CreditNotesRetrieveRequestExpandItem>))]
public enum CreditNotesRetrieveRequestExpandItem
{
    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "applied_payments")]
    AppliedPayments,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "line_items")]
    LineItems,

    [EnumMember(Value = "payments")]
    Payments,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,
}
