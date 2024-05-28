using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum CreditNotesListRequestExpand
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
    TrackingCategoriesContactCompanyAccountingPeriod
}
