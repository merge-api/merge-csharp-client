using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<ExpensesRetrieveRequestExpandItem>))]
public enum ExpensesRetrieveRequestExpandItem
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,
}
