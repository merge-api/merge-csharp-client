using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<TransactionsListRequestExpandItem>))]
public enum TransactionsListRequestExpandItem
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "line_items")]
    LineItems,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,
}
