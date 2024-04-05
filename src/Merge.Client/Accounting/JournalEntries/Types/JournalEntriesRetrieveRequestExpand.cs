using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum JournalEntriesRetrieveRequestExpand
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

    [EnumMember(Value = "applied_payments,tracking_categories")]
    AppliedPaymentsTrackingCategories,

    [EnumMember(Value = "applied_payments,tracking_categories,accounting_period")]
    AppliedPaymentsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "applied_payments,tracking_categories,company")]
    AppliedPaymentsTrackingCategoriesCompany,

    [EnumMember(Value = "applied_payments,tracking_categories,company,accounting_period")]
    AppliedPaymentsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "company,accounting_period")]
    CompanyAccountingPeriod,

    [EnumMember(Value = "lines")]
    Lines,

    [EnumMember(Value = "lines,accounting_period")]
    LinesAccountingPeriod,

    [EnumMember(Value = "lines,applied_payments")]
    LinesAppliedPayments,

    [EnumMember(Value = "lines,applied_payments,accounting_period")]
    LinesAppliedPaymentsAccountingPeriod,

    [EnumMember(Value = "lines,applied_payments,company")]
    LinesAppliedPaymentsCompany,

    [EnumMember(Value = "lines,applied_payments,company,accounting_period")]
    LinesAppliedPaymentsCompanyAccountingPeriod,

    [EnumMember(Value = "lines,applied_payments,tracking_categories")]
    LinesAppliedPaymentsTrackingCategories,

    [EnumMember(Value = "lines,applied_payments,tracking_categories,accounting_period")]
    LinesAppliedPaymentsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "lines,applied_payments,tracking_categories,company")]
    LinesAppliedPaymentsTrackingCategoriesCompany,

    [EnumMember(Value = "lines,applied_payments,tracking_categories,company,accounting_period")]
    LinesAppliedPaymentsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "lines,company")]
    LinesCompany,

    [EnumMember(Value = "lines,company,accounting_period")]
    LinesCompanyAccountingPeriod,

    [EnumMember(Value = "lines,payments")]
    LinesPayments,

    [EnumMember(Value = "lines,payments,accounting_period")]
    LinesPaymentsAccountingPeriod,

    [EnumMember(Value = "lines,payments,applied_payments")]
    LinesPaymentsAppliedPayments,

    [EnumMember(Value = "lines,payments,applied_payments,accounting_period")]
    LinesPaymentsAppliedPaymentsAccountingPeriod,

    [EnumMember(Value = "lines,payments,applied_payments,company")]
    LinesPaymentsAppliedPaymentsCompany,

    [EnumMember(Value = "lines,payments,applied_payments,company,accounting_period")]
    LinesPaymentsAppliedPaymentsCompanyAccountingPeriod,

    [EnumMember(Value = "lines,payments,applied_payments,tracking_categories")]
    LinesPaymentsAppliedPaymentsTrackingCategories,

    [EnumMember(Value = "lines,payments,applied_payments,tracking_categories,accounting_period")]
    LinesPaymentsAppliedPaymentsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "lines,payments,applied_payments,tracking_categories,company")]
    LinesPaymentsAppliedPaymentsTrackingCategoriesCompany,

    [EnumMember(Value = "lines,payments,applied_payments,tracking_categories,company,accounting_period")]
    LinesPaymentsAppliedPaymentsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "lines,payments,company")]
    LinesPaymentsCompany,

    [EnumMember(Value = "lines,payments,company,accounting_period")]
    LinesPaymentsCompanyAccountingPeriod,

    [EnumMember(Value = "lines,payments,tracking_categories")]
    LinesPaymentsTrackingCategories,

    [EnumMember(Value = "lines,payments,tracking_categories,accounting_period")]
    LinesPaymentsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "lines,payments,tracking_categories,company")]
    LinesPaymentsTrackingCategoriesCompany,

    [EnumMember(Value = "lines,payments,tracking_categories,company,accounting_period")]
    LinesPaymentsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "lines,tracking_categories")]
    LinesTrackingCategories,

    [EnumMember(Value = "lines,tracking_categories,accounting_period")]
    LinesTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "lines,tracking_categories,company")]
    LinesTrackingCategoriesCompany,

    [EnumMember(Value = "lines,tracking_categories,company,accounting_period")]
    LinesTrackingCategoriesCompanyAccountingPeriod,

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

    [EnumMember(Value = "payments,applied_payments,tracking_categories")]
    PaymentsAppliedPaymentsTrackingCategories,

    [EnumMember(Value = "payments,applied_payments,tracking_categories,accounting_period")]
    PaymentsAppliedPaymentsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "payments,applied_payments,tracking_categories,company")]
    PaymentsAppliedPaymentsTrackingCategoriesCompany,

    [EnumMember(Value = "payments,applied_payments,tracking_categories,company,accounting_period")]
    PaymentsAppliedPaymentsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "payments,company")]
    PaymentsCompany,

    [EnumMember(Value = "payments,company,accounting_period")]
    PaymentsCompanyAccountingPeriod,

    [EnumMember(Value = "payments,tracking_categories")]
    PaymentsTrackingCategories,

    [EnumMember(Value = "payments,tracking_categories,accounting_period")]
    PaymentsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "payments,tracking_categories,company")]
    PaymentsTrackingCategoriesCompany,

    [EnumMember(Value = "payments,tracking_categories,company,accounting_period")]
    PaymentsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,

    [EnumMember(Value = "tracking_categories,accounting_period")]
    TrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,company")]
    TrackingCategoriesCompany,

    [EnumMember(Value = "tracking_categories,company,accounting_period")]
    TrackingCategoriesCompanyAccountingPeriod
}
