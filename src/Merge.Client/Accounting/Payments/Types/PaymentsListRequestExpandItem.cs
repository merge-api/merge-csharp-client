using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<PaymentsListRequestExpandItem>))]
public enum PaymentsListRequestExpandItem
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "applied_to_lines")]
    AppliedToLines,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "payment_method")]
    PaymentMethod,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,
}
