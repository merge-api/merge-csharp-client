using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Accounting;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<TransactionsRetrieveRequestExpand>))]
public enum TransactionsRetrieveRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,accounting_period")]
    AccountAccountingPeriod,

    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "contact,account")]
    ContactAccount,

    [EnumMember(Value = "contact,account,accounting_period")]
    ContactAccountAccountingPeriod,

    [EnumMember(Value = "contact,accounting_period")]
    ContactAccountingPeriod,

    [EnumMember(Value = "line_items")]
    LineItems,

    [EnumMember(Value = "line_items,account")]
    LineItemsAccount,

    [EnumMember(Value = "line_items,account,accounting_period")]
    LineItemsAccountAccountingPeriod,

    [EnumMember(Value = "line_items,accounting_period")]
    LineItemsAccountingPeriod,

    [EnumMember(Value = "line_items,contact")]
    LineItemsContact,

    [EnumMember(Value = "line_items,contact,account")]
    LineItemsContactAccount,

    [EnumMember(Value = "line_items,contact,account,accounting_period")]
    LineItemsContactAccountAccountingPeriod,

    [EnumMember(Value = "line_items,contact,accounting_period")]
    LineItemsContactAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories")]
    LineItemsTrackingCategories,

    [EnumMember(Value = "line_items,tracking_categories,account")]
    LineItemsTrackingCategoriesAccount,

    [EnumMember(Value = "line_items,tracking_categories,account,accounting_period")]
    LineItemsTrackingCategoriesAccountAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,accounting_period")]
    LineItemsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,contact")]
    LineItemsTrackingCategoriesContact,

    [EnumMember(Value = "line_items,tracking_categories,contact,account")]
    LineItemsTrackingCategoriesContactAccount,

    [EnumMember(Value = "line_items,tracking_categories,contact,account,accounting_period")]
    LineItemsTrackingCategoriesContactAccountAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,contact,accounting_period")]
    LineItemsTrackingCategoriesContactAccountingPeriod,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,

    [EnumMember(Value = "tracking_categories,account")]
    TrackingCategoriesAccount,

    [EnumMember(Value = "tracking_categories,account,accounting_period")]
    TrackingCategoriesAccountAccountingPeriod,

    [EnumMember(Value = "tracking_categories,accounting_period")]
    TrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact")]
    TrackingCategoriesContact,

    [EnumMember(Value = "tracking_categories,contact,account")]
    TrackingCategoriesContactAccount,

    [EnumMember(Value = "tracking_categories,contact,account,accounting_period")]
    TrackingCategoriesContactAccountAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact,accounting_period")]
    TrackingCategoriesContactAccountingPeriod
}
