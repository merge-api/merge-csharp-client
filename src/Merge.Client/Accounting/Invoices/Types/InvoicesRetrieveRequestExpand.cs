using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<InvoicesRetrieveRequestExpand>))]
public enum InvoicesRetrieveRequestExpand
{
    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "applied_payments")]
    AppliedPayments,

    [EnumMember(Value = "applied_payments,accounting_period")]
    AppliedPaymentsAccountingPeriod,

    [EnumMember(Value = "applied_payments,company")]
    AppliedPaymentsCompany,

    [EnumMember(Value = "applied_payments,company,accounting_period")]
    AppliedPaymentsCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,contact")]
    AppliedPaymentsContact,

    [EnumMember(Value = "applied_payments,contact,accounting_period")]
    AppliedPaymentsContactAccountingPeriod,

    [EnumMember(Value = "applied_payments,contact,company")]
    AppliedPaymentsContactCompany,

    [EnumMember(Value = "applied_payments,contact,company,accounting_period")]
    AppliedPaymentsContactCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items")]
    AppliedPaymentsLineItems,

    [EnumMember(Value = "applied_payments,line_items,accounting_period")]
    AppliedPaymentsLineItemsAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,company")]
    AppliedPaymentsLineItemsCompany,

    [EnumMember(Value = "applied_payments,line_items,company,accounting_period")]
    AppliedPaymentsLineItemsCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,contact")]
    AppliedPaymentsLineItemsContact,

    [EnumMember(Value = "applied_payments,line_items,contact,accounting_period")]
    AppliedPaymentsLineItemsContactAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,contact,company")]
    AppliedPaymentsLineItemsContactCompany,

    [EnumMember(Value = "applied_payments,line_items,contact,company,accounting_period")]
    AppliedPaymentsLineItemsContactCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,purchase_orders")]
    AppliedPaymentsLineItemsPurchaseOrders,

    [EnumMember(Value = "applied_payments,line_items,purchase_orders,accounting_period")]
    AppliedPaymentsLineItemsPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,purchase_orders,company")]
    AppliedPaymentsLineItemsPurchaseOrdersCompany,

    [EnumMember(Value = "applied_payments,line_items,purchase_orders,company,accounting_period")]
    AppliedPaymentsLineItemsPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,purchase_orders,contact")]
    AppliedPaymentsLineItemsPurchaseOrdersContact,

    [EnumMember(Value = "applied_payments,line_items,purchase_orders,contact,accounting_period")]
    AppliedPaymentsLineItemsPurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,purchase_orders,contact,company")]
    AppliedPaymentsLineItemsPurchaseOrdersContactCompany,

    [EnumMember(
        Value = "applied_payments,line_items,purchase_orders,contact,company,accounting_period"
    )]
    AppliedPaymentsLineItemsPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,tracking_categories")]
    AppliedPaymentsLineItemsTrackingCategories,

    [EnumMember(Value = "applied_payments,line_items,tracking_categories,accounting_period")]
    AppliedPaymentsLineItemsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,tracking_categories,company")]
    AppliedPaymentsLineItemsTrackingCategoriesCompany,

    [EnumMember(
        Value = "applied_payments,line_items,tracking_categories,company,accounting_period"
    )]
    AppliedPaymentsLineItemsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,tracking_categories,contact")]
    AppliedPaymentsLineItemsTrackingCategoriesContact,

    [EnumMember(
        Value = "applied_payments,line_items,tracking_categories,contact,accounting_period"
    )]
    AppliedPaymentsLineItemsTrackingCategoriesContactAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,tracking_categories,contact,company")]
    AppliedPaymentsLineItemsTrackingCategoriesContactCompany,

    [EnumMember(
        Value = "applied_payments,line_items,tracking_categories,contact,company,accounting_period"
    )]
    AppliedPaymentsLineItemsTrackingCategoriesContactCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,tracking_categories,purchase_orders")]
    AppliedPaymentsLineItemsTrackingCategoriesPurchaseOrders,

    [EnumMember(
        Value = "applied_payments,line_items,tracking_categories,purchase_orders,accounting_period"
    )]
    AppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,tracking_categories,purchase_orders,company")]
    AppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersCompany,

    [EnumMember(
        Value = "applied_payments,line_items,tracking_categories,purchase_orders,company,accounting_period"
    )]
    AppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,line_items,tracking_categories,purchase_orders,contact")]
    AppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersContact,

    [EnumMember(
        Value = "applied_payments,line_items,tracking_categories,purchase_orders,contact,accounting_period"
    )]
    AppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersContactAccountingPeriod,

    [EnumMember(
        Value = "applied_payments,line_items,tracking_categories,purchase_orders,contact,company"
    )]
    AppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersContactCompany,

    [EnumMember(
        Value = "applied_payments,line_items,tracking_categories,purchase_orders,contact,company,accounting_period"
    )]
    AppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,purchase_orders")]
    AppliedPaymentsPurchaseOrders,

    [EnumMember(Value = "applied_payments,purchase_orders,accounting_period")]
    AppliedPaymentsPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "applied_payments,purchase_orders,company")]
    AppliedPaymentsPurchaseOrdersCompany,

    [EnumMember(Value = "applied_payments,purchase_orders,company,accounting_period")]
    AppliedPaymentsPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,purchase_orders,contact")]
    AppliedPaymentsPurchaseOrdersContact,

    [EnumMember(Value = "applied_payments,purchase_orders,contact,accounting_period")]
    AppliedPaymentsPurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "applied_payments,purchase_orders,contact,company")]
    AppliedPaymentsPurchaseOrdersContactCompany,

    [EnumMember(Value = "applied_payments,purchase_orders,contact,company,accounting_period")]
    AppliedPaymentsPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,tracking_categories")]
    AppliedPaymentsTrackingCategories,

    [EnumMember(Value = "applied_payments,tracking_categories,accounting_period")]
    AppliedPaymentsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "applied_payments,tracking_categories,company")]
    AppliedPaymentsTrackingCategoriesCompany,

    [EnumMember(Value = "applied_payments,tracking_categories,company,accounting_period")]
    AppliedPaymentsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,tracking_categories,contact")]
    AppliedPaymentsTrackingCategoriesContact,

    [EnumMember(Value = "applied_payments,tracking_categories,contact,accounting_period")]
    AppliedPaymentsTrackingCategoriesContactAccountingPeriod,

    [EnumMember(Value = "applied_payments,tracking_categories,contact,company")]
    AppliedPaymentsTrackingCategoriesContactCompany,

    [EnumMember(Value = "applied_payments,tracking_categories,contact,company,accounting_period")]
    AppliedPaymentsTrackingCategoriesContactCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,tracking_categories,purchase_orders")]
    AppliedPaymentsTrackingCategoriesPurchaseOrders,

    [EnumMember(Value = "applied_payments,tracking_categories,purchase_orders,accounting_period")]
    AppliedPaymentsTrackingCategoriesPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "applied_payments,tracking_categories,purchase_orders,company")]
    AppliedPaymentsTrackingCategoriesPurchaseOrdersCompany,

    [EnumMember(
        Value = "applied_payments,tracking_categories,purchase_orders,company,accounting_period"
    )]
    AppliedPaymentsTrackingCategoriesPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "applied_payments,tracking_categories,purchase_orders,contact")]
    AppliedPaymentsTrackingCategoriesPurchaseOrdersContact,

    [EnumMember(
        Value = "applied_payments,tracking_categories,purchase_orders,contact,accounting_period"
    )]
    AppliedPaymentsTrackingCategoriesPurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "applied_payments,tracking_categories,purchase_orders,contact,company")]
    AppliedPaymentsTrackingCategoriesPurchaseOrdersContactCompany,

    [EnumMember(
        Value = "applied_payments,tracking_categories,purchase_orders,contact,company,accounting_period"
    )]
    AppliedPaymentsTrackingCategoriesPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "company,accounting_period")]
    CompanyAccountingPeriod,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "contact,accounting_period")]
    ContactAccountingPeriod,

    [EnumMember(Value = "contact,company")]
    ContactCompany,

    [EnumMember(Value = "contact,company,accounting_period")]
    ContactCompanyAccountingPeriod,

    [EnumMember(Value = "line_items")]
    LineItems,

    [EnumMember(Value = "line_items,accounting_period")]
    LineItemsAccountingPeriod,

    [EnumMember(Value = "line_items,company")]
    LineItemsCompany,

    [EnumMember(Value = "line_items,company,accounting_period")]
    LineItemsCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,contact")]
    LineItemsContact,

    [EnumMember(Value = "line_items,contact,accounting_period")]
    LineItemsContactAccountingPeriod,

    [EnumMember(Value = "line_items,contact,company")]
    LineItemsContactCompany,

    [EnumMember(Value = "line_items,contact,company,accounting_period")]
    LineItemsContactCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,purchase_orders")]
    LineItemsPurchaseOrders,

    [EnumMember(Value = "line_items,purchase_orders,accounting_period")]
    LineItemsPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "line_items,purchase_orders,company")]
    LineItemsPurchaseOrdersCompany,

    [EnumMember(Value = "line_items,purchase_orders,company,accounting_period")]
    LineItemsPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,purchase_orders,contact")]
    LineItemsPurchaseOrdersContact,

    [EnumMember(Value = "line_items,purchase_orders,contact,accounting_period")]
    LineItemsPurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "line_items,purchase_orders,contact,company")]
    LineItemsPurchaseOrdersContactCompany,

    [EnumMember(Value = "line_items,purchase_orders,contact,company,accounting_period")]
    LineItemsPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories")]
    LineItemsTrackingCategories,

    [EnumMember(Value = "line_items,tracking_categories,accounting_period")]
    LineItemsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,company")]
    LineItemsTrackingCategoriesCompany,

    [EnumMember(Value = "line_items,tracking_categories,company,accounting_period")]
    LineItemsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,contact")]
    LineItemsTrackingCategoriesContact,

    [EnumMember(Value = "line_items,tracking_categories,contact,accounting_period")]
    LineItemsTrackingCategoriesContactAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,contact,company")]
    LineItemsTrackingCategoriesContactCompany,

    [EnumMember(Value = "line_items,tracking_categories,contact,company,accounting_period")]
    LineItemsTrackingCategoriesContactCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,purchase_orders")]
    LineItemsTrackingCategoriesPurchaseOrders,

    [EnumMember(Value = "line_items,tracking_categories,purchase_orders,accounting_period")]
    LineItemsTrackingCategoriesPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,purchase_orders,company")]
    LineItemsTrackingCategoriesPurchaseOrdersCompany,

    [EnumMember(Value = "line_items,tracking_categories,purchase_orders,company,accounting_period")]
    LineItemsTrackingCategoriesPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,purchase_orders,contact")]
    LineItemsTrackingCategoriesPurchaseOrdersContact,

    [EnumMember(Value = "line_items,tracking_categories,purchase_orders,contact,accounting_period")]
    LineItemsTrackingCategoriesPurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,purchase_orders,contact,company")]
    LineItemsTrackingCategoriesPurchaseOrdersContactCompany,

    [EnumMember(
        Value = "line_items,tracking_categories,purchase_orders,contact,company,accounting_period"
    )]
    LineItemsTrackingCategoriesPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments")]
    Payments,

    [EnumMember(Value = "payments,accounting_period")]
    PaymentsAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments")]
    PaymentsAppliedPayments,

    [EnumMember(Value = "payments,applied_payments,accounting_period")]
    PaymentsAppliedPaymentsAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,company")]
    PaymentsAppliedPaymentsCompany,

    [EnumMember(Value = "payments,applied_payments,company,accounting_period")]
    PaymentsAppliedPaymentsCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,contact")]
    PaymentsAppliedPaymentsContact,

    [EnumMember(Value = "payments,applied_payments,contact,accounting_period")]
    PaymentsAppliedPaymentsContactAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,contact,company")]
    PaymentsAppliedPaymentsContactCompany,

    [EnumMember(Value = "payments,applied_payments,contact,company,accounting_period")]
    PaymentsAppliedPaymentsContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items")]
    PaymentsAppliedPaymentsLineItems,

    [EnumMember(Value = "payments,applied_payments,line_items,accounting_period")]
    PaymentsAppliedPaymentsLineItemsAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items,company")]
    PaymentsAppliedPaymentsLineItemsCompany,

    [EnumMember(Value = "payments,applied_payments,line_items,company,accounting_period")]
    PaymentsAppliedPaymentsLineItemsCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items,contact")]
    PaymentsAppliedPaymentsLineItemsContact,

    [EnumMember(Value = "payments,applied_payments,line_items,contact,accounting_period")]
    PaymentsAppliedPaymentsLineItemsContactAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items,contact,company")]
    PaymentsAppliedPaymentsLineItemsContactCompany,

    [EnumMember(Value = "payments,applied_payments,line_items,contact,company,accounting_period")]
    PaymentsAppliedPaymentsLineItemsContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items,purchase_orders")]
    PaymentsAppliedPaymentsLineItemsPurchaseOrders,

    [EnumMember(Value = "payments,applied_payments,line_items,purchase_orders,accounting_period")]
    PaymentsAppliedPaymentsLineItemsPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items,purchase_orders,company")]
    PaymentsAppliedPaymentsLineItemsPurchaseOrdersCompany,

    [EnumMember(
        Value = "payments,applied_payments,line_items,purchase_orders,company,accounting_period"
    )]
    PaymentsAppliedPaymentsLineItemsPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items,purchase_orders,contact")]
    PaymentsAppliedPaymentsLineItemsPurchaseOrdersContact,

    [EnumMember(
        Value = "payments,applied_payments,line_items,purchase_orders,contact,accounting_period"
    )]
    PaymentsAppliedPaymentsLineItemsPurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items,purchase_orders,contact,company")]
    PaymentsAppliedPaymentsLineItemsPurchaseOrdersContactCompany,

    [EnumMember(
        Value = "payments,applied_payments,line_items,purchase_orders,contact,company,accounting_period"
    )]
    PaymentsAppliedPaymentsLineItemsPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items,tracking_categories")]
    PaymentsAppliedPaymentsLineItemsTrackingCategories,

    [EnumMember(
        Value = "payments,applied_payments,line_items,tracking_categories,accounting_period"
    )]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items,tracking_categories,company")]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesCompany,

    [EnumMember(
        Value = "payments,applied_payments,line_items,tracking_categories,company,accounting_period"
    )]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items,tracking_categories,contact")]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesContact,

    [EnumMember(
        Value = "payments,applied_payments,line_items,tracking_categories,contact,accounting_period"
    )]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesContactAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items,tracking_categories,contact,company")]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesContactCompany,

    [EnumMember(
        Value = "payments,applied_payments,line_items,tracking_categories,contact,company,accounting_period"
    )]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,line_items,tracking_categories,purchase_orders")]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesPurchaseOrders,

    [EnumMember(
        Value = "payments,applied_payments,line_items,tracking_categories,purchase_orders,accounting_period"
    )]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersAccountingPeriod,

    [EnumMember(
        Value = "payments,applied_payments,line_items,tracking_categories,purchase_orders,company"
    )]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersCompany,

    [EnumMember(
        Value = "payments,applied_payments,line_items,tracking_categories,purchase_orders,company,accounting_period"
    )]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(
        Value = "payments,applied_payments,line_items,tracking_categories,purchase_orders,contact"
    )]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersContact,

    [EnumMember(
        Value = "payments,applied_payments,line_items,tracking_categories,purchase_orders,contact,accounting_period"
    )]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersContactAccountingPeriod,

    [EnumMember(
        Value = "payments,applied_payments,line_items,tracking_categories,purchase_orders,contact,company"
    )]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersContactCompany,

    [EnumMember(
        Value = "payments,applied_payments,line_items,tracking_categories,purchase_orders,contact,company,accounting_period"
    )]
    PaymentsAppliedPaymentsLineItemsTrackingCategoriesPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,purchase_orders")]
    PaymentsAppliedPaymentsPurchaseOrders,

    [EnumMember(Value = "payments,applied_payments,purchase_orders,accounting_period")]
    PaymentsAppliedPaymentsPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,purchase_orders,company")]
    PaymentsAppliedPaymentsPurchaseOrdersCompany,

    [EnumMember(Value = "payments,applied_payments,purchase_orders,company,accounting_period")]
    PaymentsAppliedPaymentsPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,purchase_orders,contact")]
    PaymentsAppliedPaymentsPurchaseOrdersContact,

    [EnumMember(Value = "payments,applied_payments,purchase_orders,contact,accounting_period")]
    PaymentsAppliedPaymentsPurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,purchase_orders,contact,company")]
    PaymentsAppliedPaymentsPurchaseOrdersContactCompany,

    [EnumMember(
        Value = "payments,applied_payments,purchase_orders,contact,company,accounting_period"
    )]
    PaymentsAppliedPaymentsPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,tracking_categories")]
    PaymentsAppliedPaymentsTrackingCategories,

    [EnumMember(Value = "payments,applied_payments,tracking_categories,accounting_period")]
    PaymentsAppliedPaymentsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,tracking_categories,company")]
    PaymentsAppliedPaymentsTrackingCategoriesCompany,

    [EnumMember(Value = "payments,applied_payments,tracking_categories,company,accounting_period")]
    PaymentsAppliedPaymentsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,tracking_categories,contact")]
    PaymentsAppliedPaymentsTrackingCategoriesContact,

    [EnumMember(Value = "payments,applied_payments,tracking_categories,contact,accounting_period")]
    PaymentsAppliedPaymentsTrackingCategoriesContactAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,tracking_categories,contact,company")]
    PaymentsAppliedPaymentsTrackingCategoriesContactCompany,

    [EnumMember(
        Value = "payments,applied_payments,tracking_categories,contact,company,accounting_period"
    )]
    PaymentsAppliedPaymentsTrackingCategoriesContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,tracking_categories,purchase_orders")]
    PaymentsAppliedPaymentsTrackingCategoriesPurchaseOrders,

    [EnumMember(
        Value = "payments,applied_payments,tracking_categories,purchase_orders,accounting_period"
    )]
    PaymentsAppliedPaymentsTrackingCategoriesPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,tracking_categories,purchase_orders,company")]
    PaymentsAppliedPaymentsTrackingCategoriesPurchaseOrdersCompany,

    [EnumMember(
        Value = "payments,applied_payments,tracking_categories,purchase_orders,company,accounting_period"
    )]
    PaymentsAppliedPaymentsTrackingCategoriesPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,tracking_categories,purchase_orders,contact")]
    PaymentsAppliedPaymentsTrackingCategoriesPurchaseOrdersContact,

    [EnumMember(
        Value = "payments,applied_payments,tracking_categories,purchase_orders,contact,accounting_period"
    )]
    PaymentsAppliedPaymentsTrackingCategoriesPurchaseOrdersContactAccountingPeriod,

    [EnumMember(
        Value = "payments,applied_payments,tracking_categories,purchase_orders,contact,company"
    )]
    PaymentsAppliedPaymentsTrackingCategoriesPurchaseOrdersContactCompany,

    [EnumMember(
        Value = "payments,applied_payments,tracking_categories,purchase_orders,contact,company,accounting_period"
    )]
    PaymentsAppliedPaymentsTrackingCategoriesPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,company")]
    PaymentsCompany,

    [EnumMember(Value = "payments,company,accounting_period")]
    PaymentsCompanyAccountingPeriod,

    [EnumMember(Value = "payments,contact")]
    PaymentsContact,

    [EnumMember(Value = "payments,contact,accounting_period")]
    PaymentsContactAccountingPeriod,

    [EnumMember(Value = "payments,contact,company")]
    PaymentsContactCompany,

    [EnumMember(Value = "payments,contact,company,accounting_period")]
    PaymentsContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,line_items")]
    PaymentsLineItems,

    [EnumMember(Value = "payments,line_items,accounting_period")]
    PaymentsLineItemsAccountingPeriod,

    [EnumMember(Value = "payments,line_items,company")]
    PaymentsLineItemsCompany,

    [EnumMember(Value = "payments,line_items,company,accounting_period")]
    PaymentsLineItemsCompanyAccountingPeriod,

    [EnumMember(Value = "payments,line_items,contact")]
    PaymentsLineItemsContact,

    [EnumMember(Value = "payments,line_items,contact,accounting_period")]
    PaymentsLineItemsContactAccountingPeriod,

    [EnumMember(Value = "payments,line_items,contact,company")]
    PaymentsLineItemsContactCompany,

    [EnumMember(Value = "payments,line_items,contact,company,accounting_period")]
    PaymentsLineItemsContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,line_items,purchase_orders")]
    PaymentsLineItemsPurchaseOrders,

    [EnumMember(Value = "payments,line_items,purchase_orders,accounting_period")]
    PaymentsLineItemsPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "payments,line_items,purchase_orders,company")]
    PaymentsLineItemsPurchaseOrdersCompany,

    [EnumMember(Value = "payments,line_items,purchase_orders,company,accounting_period")]
    PaymentsLineItemsPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "payments,line_items,purchase_orders,contact")]
    PaymentsLineItemsPurchaseOrdersContact,

    [EnumMember(Value = "payments,line_items,purchase_orders,contact,accounting_period")]
    PaymentsLineItemsPurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "payments,line_items,purchase_orders,contact,company")]
    PaymentsLineItemsPurchaseOrdersContactCompany,

    [EnumMember(Value = "payments,line_items,purchase_orders,contact,company,accounting_period")]
    PaymentsLineItemsPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,line_items,tracking_categories")]
    PaymentsLineItemsTrackingCategories,

    [EnumMember(Value = "payments,line_items,tracking_categories,accounting_period")]
    PaymentsLineItemsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "payments,line_items,tracking_categories,company")]
    PaymentsLineItemsTrackingCategoriesCompany,

    [EnumMember(Value = "payments,line_items,tracking_categories,company,accounting_period")]
    PaymentsLineItemsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "payments,line_items,tracking_categories,contact")]
    PaymentsLineItemsTrackingCategoriesContact,

    [EnumMember(Value = "payments,line_items,tracking_categories,contact,accounting_period")]
    PaymentsLineItemsTrackingCategoriesContactAccountingPeriod,

    [EnumMember(Value = "payments,line_items,tracking_categories,contact,company")]
    PaymentsLineItemsTrackingCategoriesContactCompany,

    [EnumMember(
        Value = "payments,line_items,tracking_categories,contact,company,accounting_period"
    )]
    PaymentsLineItemsTrackingCategoriesContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,line_items,tracking_categories,purchase_orders")]
    PaymentsLineItemsTrackingCategoriesPurchaseOrders,

    [EnumMember(
        Value = "payments,line_items,tracking_categories,purchase_orders,accounting_period"
    )]
    PaymentsLineItemsTrackingCategoriesPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "payments,line_items,tracking_categories,purchase_orders,company")]
    PaymentsLineItemsTrackingCategoriesPurchaseOrdersCompany,

    [EnumMember(
        Value = "payments,line_items,tracking_categories,purchase_orders,company,accounting_period"
    )]
    PaymentsLineItemsTrackingCategoriesPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "payments,line_items,tracking_categories,purchase_orders,contact")]
    PaymentsLineItemsTrackingCategoriesPurchaseOrdersContact,

    [EnumMember(
        Value = "payments,line_items,tracking_categories,purchase_orders,contact,accounting_period"
    )]
    PaymentsLineItemsTrackingCategoriesPurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "payments,line_items,tracking_categories,purchase_orders,contact,company")]
    PaymentsLineItemsTrackingCategoriesPurchaseOrdersContactCompany,

    [EnumMember(
        Value = "payments,line_items,tracking_categories,purchase_orders,contact,company,accounting_period"
    )]
    PaymentsLineItemsTrackingCategoriesPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,purchase_orders")]
    PaymentsPurchaseOrders,

    [EnumMember(Value = "payments,purchase_orders,accounting_period")]
    PaymentsPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "payments,purchase_orders,company")]
    PaymentsPurchaseOrdersCompany,

    [EnumMember(Value = "payments,purchase_orders,company,accounting_period")]
    PaymentsPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "payments,purchase_orders,contact")]
    PaymentsPurchaseOrdersContact,

    [EnumMember(Value = "payments,purchase_orders,contact,accounting_period")]
    PaymentsPurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "payments,purchase_orders,contact,company")]
    PaymentsPurchaseOrdersContactCompany,

    [EnumMember(Value = "payments,purchase_orders,contact,company,accounting_period")]
    PaymentsPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,tracking_categories")]
    PaymentsTrackingCategories,

    [EnumMember(Value = "payments,tracking_categories,accounting_period")]
    PaymentsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "payments,tracking_categories,company")]
    PaymentsTrackingCategoriesCompany,

    [EnumMember(Value = "payments,tracking_categories,company,accounting_period")]
    PaymentsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "payments,tracking_categories,contact")]
    PaymentsTrackingCategoriesContact,

    [EnumMember(Value = "payments,tracking_categories,contact,accounting_period")]
    PaymentsTrackingCategoriesContactAccountingPeriod,

    [EnumMember(Value = "payments,tracking_categories,contact,company")]
    PaymentsTrackingCategoriesContactCompany,

    [EnumMember(Value = "payments,tracking_categories,contact,company,accounting_period")]
    PaymentsTrackingCategoriesContactCompanyAccountingPeriod,

    [EnumMember(Value = "payments,tracking_categories,purchase_orders")]
    PaymentsTrackingCategoriesPurchaseOrders,

    [EnumMember(Value = "payments,tracking_categories,purchase_orders,accounting_period")]
    PaymentsTrackingCategoriesPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "payments,tracking_categories,purchase_orders,company")]
    PaymentsTrackingCategoriesPurchaseOrdersCompany,

    [EnumMember(Value = "payments,tracking_categories,purchase_orders,company,accounting_period")]
    PaymentsTrackingCategoriesPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "payments,tracking_categories,purchase_orders,contact")]
    PaymentsTrackingCategoriesPurchaseOrdersContact,

    [EnumMember(Value = "payments,tracking_categories,purchase_orders,contact,accounting_period")]
    PaymentsTrackingCategoriesPurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "payments,tracking_categories,purchase_orders,contact,company")]
    PaymentsTrackingCategoriesPurchaseOrdersContactCompany,

    [EnumMember(
        Value = "payments,tracking_categories,purchase_orders,contact,company,accounting_period"
    )]
    PaymentsTrackingCategoriesPurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "purchase_orders")]
    PurchaseOrders,

    [EnumMember(Value = "purchase_orders,accounting_period")]
    PurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "purchase_orders,company")]
    PurchaseOrdersCompany,

    [EnumMember(Value = "purchase_orders,company,accounting_period")]
    PurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "purchase_orders,contact")]
    PurchaseOrdersContact,

    [EnumMember(Value = "purchase_orders,contact,accounting_period")]
    PurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "purchase_orders,contact,company")]
    PurchaseOrdersContactCompany,

    [EnumMember(Value = "purchase_orders,contact,company,accounting_period")]
    PurchaseOrdersContactCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,

    [EnumMember(Value = "tracking_categories,accounting_period")]
    TrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,company")]
    TrackingCategoriesCompany,

    [EnumMember(Value = "tracking_categories,company,accounting_period")]
    TrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact")]
    TrackingCategoriesContact,

    [EnumMember(Value = "tracking_categories,contact,accounting_period")]
    TrackingCategoriesContactAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact,company")]
    TrackingCategoriesContactCompany,

    [EnumMember(Value = "tracking_categories,contact,company,accounting_period")]
    TrackingCategoriesContactCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,purchase_orders")]
    TrackingCategoriesPurchaseOrders,

    [EnumMember(Value = "tracking_categories,purchase_orders,accounting_period")]
    TrackingCategoriesPurchaseOrdersAccountingPeriod,

    [EnumMember(Value = "tracking_categories,purchase_orders,company")]
    TrackingCategoriesPurchaseOrdersCompany,

    [EnumMember(Value = "tracking_categories,purchase_orders,company,accounting_period")]
    TrackingCategoriesPurchaseOrdersCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,purchase_orders,contact")]
    TrackingCategoriesPurchaseOrdersContact,

    [EnumMember(Value = "tracking_categories,purchase_orders,contact,accounting_period")]
    TrackingCategoriesPurchaseOrdersContactAccountingPeriod,

    [EnumMember(Value = "tracking_categories,purchase_orders,contact,company")]
    TrackingCategoriesPurchaseOrdersContactCompany,

    [EnumMember(Value = "tracking_categories,purchase_orders,contact,company,accounting_period")]
    TrackingCategoriesPurchaseOrdersContactCompanyAccountingPeriod
}
