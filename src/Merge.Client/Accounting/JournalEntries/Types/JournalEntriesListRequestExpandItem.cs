using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<JournalEntriesListRequestExpandItem>))]
public enum JournalEntriesListRequestExpandItem
{
    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "applied_payments")]
    AppliedPayments,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "lines")]
    Lines,

    [EnumMember(Value = "payments")]
    Payments,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,
}
