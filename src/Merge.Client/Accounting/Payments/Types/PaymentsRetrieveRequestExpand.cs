using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<PaymentsRetrieveRequestExpand>))]
public enum PaymentsRetrieveRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,accounting_period")]
    AccountAccountingPeriod,

    [EnumMember(Value = "account,accounting_period,payment_method")]
    AccountAccountingPeriodPaymentMethod,

    [EnumMember(Value = "account,company")]
    AccountCompany,

    [EnumMember(Value = "account,company,accounting_period")]
    AccountCompanyAccountingPeriod,

    [EnumMember(Value = "account,company,accounting_period,payment_method")]
    AccountCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "account,company,payment_method")]
    AccountCompanyPaymentMethod,

    [EnumMember(Value = "account,payment_method")]
    AccountPaymentMethod,

    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "accounting_period,payment_method")]
    AccountingPeriodPaymentMethod,

    [EnumMember(Value = "applied_to_lines")]
    AppliedToLines,

    [EnumMember(Value = "applied_to_lines,account")]
    AppliedToLinesAccount,

    [EnumMember(Value = "applied_to_lines,account,accounting_period")]
    AppliedToLinesAccountAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,account,accounting_period,payment_method")]
    AppliedToLinesAccountAccountingPeriodPaymentMethod,

    [EnumMember(Value = "applied_to_lines,account,company")]
    AppliedToLinesAccountCompany,

    [EnumMember(Value = "applied_to_lines,account,company,accounting_period")]
    AppliedToLinesAccountCompanyAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,account,company,accounting_period,payment_method")]
    AppliedToLinesAccountCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "applied_to_lines,account,company,payment_method")]
    AppliedToLinesAccountCompanyPaymentMethod,

    [EnumMember(Value = "applied_to_lines,account,payment_method")]
    AppliedToLinesAccountPaymentMethod,

    [EnumMember(Value = "applied_to_lines,accounting_period")]
    AppliedToLinesAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,accounting_period,payment_method")]
    AppliedToLinesAccountingPeriodPaymentMethod,

    [EnumMember(Value = "applied_to_lines,company")]
    AppliedToLinesCompany,

    [EnumMember(Value = "applied_to_lines,company,accounting_period")]
    AppliedToLinesCompanyAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,company,accounting_period,payment_method")]
    AppliedToLinesCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "applied_to_lines,company,payment_method")]
    AppliedToLinesCompanyPaymentMethod,

    [EnumMember(Value = "applied_to_lines,contact")]
    AppliedToLinesContact,

    [EnumMember(Value = "applied_to_lines,contact,account")]
    AppliedToLinesContactAccount,

    [EnumMember(Value = "applied_to_lines,contact,account,accounting_period")]
    AppliedToLinesContactAccountAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,contact,account,accounting_period,payment_method")]
    AppliedToLinesContactAccountAccountingPeriodPaymentMethod,

    [EnumMember(Value = "applied_to_lines,contact,account,company")]
    AppliedToLinesContactAccountCompany,

    [EnumMember(Value = "applied_to_lines,contact,account,company,accounting_period")]
    AppliedToLinesContactAccountCompanyAccountingPeriod,

    [EnumMember(
        Value = "applied_to_lines,contact,account,company,accounting_period,payment_method"
    )]
    AppliedToLinesContactAccountCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "applied_to_lines,contact,account,company,payment_method")]
    AppliedToLinesContactAccountCompanyPaymentMethod,

    [EnumMember(Value = "applied_to_lines,contact,account,payment_method")]
    AppliedToLinesContactAccountPaymentMethod,

    [EnumMember(Value = "applied_to_lines,contact,accounting_period")]
    AppliedToLinesContactAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,contact,accounting_period,payment_method")]
    AppliedToLinesContactAccountingPeriodPaymentMethod,

    [EnumMember(Value = "applied_to_lines,contact,company")]
    AppliedToLinesContactCompany,

    [EnumMember(Value = "applied_to_lines,contact,company,accounting_period")]
    AppliedToLinesContactCompanyAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,contact,company,accounting_period,payment_method")]
    AppliedToLinesContactCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "applied_to_lines,contact,company,payment_method")]
    AppliedToLinesContactCompanyPaymentMethod,

    [EnumMember(Value = "applied_to_lines,contact,payment_method")]
    AppliedToLinesContactPaymentMethod,

    [EnumMember(Value = "applied_to_lines,payment_method")]
    AppliedToLinesPaymentMethod,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "company,accounting_period")]
    CompanyAccountingPeriod,

    [EnumMember(Value = "company,accounting_period,payment_method")]
    CompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "company,payment_method")]
    CompanyPaymentMethod,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "contact,account")]
    ContactAccount,

    [EnumMember(Value = "contact,account,accounting_period")]
    ContactAccountAccountingPeriod,

    [EnumMember(Value = "contact,account,accounting_period,payment_method")]
    ContactAccountAccountingPeriodPaymentMethod,

    [EnumMember(Value = "contact,account,company")]
    ContactAccountCompany,

    [EnumMember(Value = "contact,account,company,accounting_period")]
    ContactAccountCompanyAccountingPeriod,

    [EnumMember(Value = "contact,account,company,accounting_period,payment_method")]
    ContactAccountCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "contact,account,company,payment_method")]
    ContactAccountCompanyPaymentMethod,

    [EnumMember(Value = "contact,account,payment_method")]
    ContactAccountPaymentMethod,

    [EnumMember(Value = "contact,accounting_period")]
    ContactAccountingPeriod,

    [EnumMember(Value = "contact,accounting_period,payment_method")]
    ContactAccountingPeriodPaymentMethod,

    [EnumMember(Value = "contact,company")]
    ContactCompany,

    [EnumMember(Value = "contact,company,accounting_period")]
    ContactCompanyAccountingPeriod,

    [EnumMember(Value = "contact,company,accounting_period,payment_method")]
    ContactCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "contact,company,payment_method")]
    ContactCompanyPaymentMethod,

    [EnumMember(Value = "contact,payment_method")]
    ContactPaymentMethod,

    [EnumMember(Value = "payment_method")]
    PaymentMethod,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,

    [EnumMember(Value = "tracking_categories,account")]
    TrackingCategoriesAccount,

    [EnumMember(Value = "tracking_categories,account,accounting_period")]
    TrackingCategoriesAccountAccountingPeriod,

    [EnumMember(Value = "tracking_categories,account,accounting_period,payment_method")]
    TrackingCategoriesAccountAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,account,company")]
    TrackingCategoriesAccountCompany,

    [EnumMember(Value = "tracking_categories,account,company,accounting_period")]
    TrackingCategoriesAccountCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,account,company,accounting_period,payment_method")]
    TrackingCategoriesAccountCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,account,company,payment_method")]
    TrackingCategoriesAccountCompanyPaymentMethod,

    [EnumMember(Value = "tracking_categories,account,payment_method")]
    TrackingCategoriesAccountPaymentMethod,

    [EnumMember(Value = "tracking_categories,accounting_period")]
    TrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,accounting_period,payment_method")]
    TrackingCategoriesAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines")]
    TrackingCategoriesAppliedToLines,

    [EnumMember(Value = "tracking_categories,applied_to_lines,account")]
    TrackingCategoriesAppliedToLinesAccount,

    [EnumMember(Value = "tracking_categories,applied_to_lines,account,accounting_period")]
    TrackingCategoriesAppliedToLinesAccountAccountingPeriod,

    [EnumMember(
        Value = "tracking_categories,applied_to_lines,account,accounting_period,payment_method"
    )]
    TrackingCategoriesAppliedToLinesAccountAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,account,company")]
    TrackingCategoriesAppliedToLinesAccountCompany,

    [EnumMember(Value = "tracking_categories,applied_to_lines,account,company,accounting_period")]
    TrackingCategoriesAppliedToLinesAccountCompanyAccountingPeriod,

    [EnumMember(
        Value = "tracking_categories,applied_to_lines,account,company,accounting_period,payment_method"
    )]
    TrackingCategoriesAppliedToLinesAccountCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,account,company,payment_method")]
    TrackingCategoriesAppliedToLinesAccountCompanyPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,account,payment_method")]
    TrackingCategoriesAppliedToLinesAccountPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,accounting_period")]
    TrackingCategoriesAppliedToLinesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,accounting_period,payment_method")]
    TrackingCategoriesAppliedToLinesAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,company")]
    TrackingCategoriesAppliedToLinesCompany,

    [EnumMember(Value = "tracking_categories,applied_to_lines,company,accounting_period")]
    TrackingCategoriesAppliedToLinesCompanyAccountingPeriod,

    [EnumMember(
        Value = "tracking_categories,applied_to_lines,company,accounting_period,payment_method"
    )]
    TrackingCategoriesAppliedToLinesCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,company,payment_method")]
    TrackingCategoriesAppliedToLinesCompanyPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact")]
    TrackingCategoriesAppliedToLinesContact,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,account")]
    TrackingCategoriesAppliedToLinesContactAccount,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,account,accounting_period")]
    TrackingCategoriesAppliedToLinesContactAccountAccountingPeriod,

    [EnumMember(
        Value = "tracking_categories,applied_to_lines,contact,account,accounting_period,payment_method"
    )]
    TrackingCategoriesAppliedToLinesContactAccountAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,account,company")]
    TrackingCategoriesAppliedToLinesContactAccountCompany,

    [EnumMember(
        Value = "tracking_categories,applied_to_lines,contact,account,company,accounting_period"
    )]
    TrackingCategoriesAppliedToLinesContactAccountCompanyAccountingPeriod,

    [EnumMember(
        Value = "tracking_categories,applied_to_lines,contact,account,company,accounting_period,payment_method"
    )]
    TrackingCategoriesAppliedToLinesContactAccountCompanyAccountingPeriodPaymentMethod,

    [EnumMember(
        Value = "tracking_categories,applied_to_lines,contact,account,company,payment_method"
    )]
    TrackingCategoriesAppliedToLinesContactAccountCompanyPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,account,payment_method")]
    TrackingCategoriesAppliedToLinesContactAccountPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,accounting_period")]
    TrackingCategoriesAppliedToLinesContactAccountingPeriod,

    [EnumMember(
        Value = "tracking_categories,applied_to_lines,contact,accounting_period,payment_method"
    )]
    TrackingCategoriesAppliedToLinesContactAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,company")]
    TrackingCategoriesAppliedToLinesContactCompany,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,company,accounting_period")]
    TrackingCategoriesAppliedToLinesContactCompanyAccountingPeriod,

    [EnumMember(
        Value = "tracking_categories,applied_to_lines,contact,company,accounting_period,payment_method"
    )]
    TrackingCategoriesAppliedToLinesContactCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,company,payment_method")]
    TrackingCategoriesAppliedToLinesContactCompanyPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,payment_method")]
    TrackingCategoriesAppliedToLinesContactPaymentMethod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,payment_method")]
    TrackingCategoriesAppliedToLinesPaymentMethod,

    [EnumMember(Value = "tracking_categories,company")]
    TrackingCategoriesCompany,

    [EnumMember(Value = "tracking_categories,company,accounting_period")]
    TrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,company,accounting_period,payment_method")]
    TrackingCategoriesCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,company,payment_method")]
    TrackingCategoriesCompanyPaymentMethod,

    [EnumMember(Value = "tracking_categories,contact")]
    TrackingCategoriesContact,

    [EnumMember(Value = "tracking_categories,contact,account")]
    TrackingCategoriesContactAccount,

    [EnumMember(Value = "tracking_categories,contact,account,accounting_period")]
    TrackingCategoriesContactAccountAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact,account,accounting_period,payment_method")]
    TrackingCategoriesContactAccountAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,contact,account,company")]
    TrackingCategoriesContactAccountCompany,

    [EnumMember(Value = "tracking_categories,contact,account,company,accounting_period")]
    TrackingCategoriesContactAccountCompanyAccountingPeriod,

    [EnumMember(
        Value = "tracking_categories,contact,account,company,accounting_period,payment_method"
    )]
    TrackingCategoriesContactAccountCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,contact,account,company,payment_method")]
    TrackingCategoriesContactAccountCompanyPaymentMethod,

    [EnumMember(Value = "tracking_categories,contact,account,payment_method")]
    TrackingCategoriesContactAccountPaymentMethod,

    [EnumMember(Value = "tracking_categories,contact,accounting_period")]
    TrackingCategoriesContactAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact,accounting_period,payment_method")]
    TrackingCategoriesContactAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,contact,company")]
    TrackingCategoriesContactCompany,

    [EnumMember(Value = "tracking_categories,contact,company,accounting_period")]
    TrackingCategoriesContactCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact,company,accounting_period,payment_method")]
    TrackingCategoriesContactCompanyAccountingPeriodPaymentMethod,

    [EnumMember(Value = "tracking_categories,contact,company,payment_method")]
    TrackingCategoriesContactCompanyPaymentMethod,

    [EnumMember(Value = "tracking_categories,contact,payment_method")]
    TrackingCategoriesContactPaymentMethod,

    [EnumMember(Value = "tracking_categories,payment_method")]
    TrackingCategoriesPaymentMethod,
}
