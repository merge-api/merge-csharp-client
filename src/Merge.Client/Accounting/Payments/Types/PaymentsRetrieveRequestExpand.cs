using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<PaymentsRetrieveRequestExpand>))]
public enum PaymentsRetrieveRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,accounting_period")]
    AccountAccountingPeriod,

    [EnumMember(Value = "account,company")]
    AccountCompany,

    [EnumMember(Value = "account,company,accounting_period")]
    AccountCompanyAccountingPeriod,

    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "applied_to_lines")]
    AppliedToLines,

    [EnumMember(Value = "applied_to_lines,account")]
    AppliedToLinesAccount,

    [EnumMember(Value = "applied_to_lines,account,accounting_period")]
    AppliedToLinesAccountAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,account,company")]
    AppliedToLinesAccountCompany,

    [EnumMember(Value = "applied_to_lines,account,company,accounting_period")]
    AppliedToLinesAccountCompanyAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,accounting_period")]
    AppliedToLinesAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,company")]
    AppliedToLinesCompany,

    [EnumMember(Value = "applied_to_lines,company,accounting_period")]
    AppliedToLinesCompanyAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,contact")]
    AppliedToLinesContact,

    [EnumMember(Value = "applied_to_lines,contact,account")]
    AppliedToLinesContactAccount,

    [EnumMember(Value = "applied_to_lines,contact,account,accounting_period")]
    AppliedToLinesContactAccountAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,contact,account,company")]
    AppliedToLinesContactAccountCompany,

    [EnumMember(Value = "applied_to_lines,contact,account,company,accounting_period")]
    AppliedToLinesContactAccountCompanyAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,contact,accounting_period")]
    AppliedToLinesContactAccountingPeriod,

    [EnumMember(Value = "applied_to_lines,contact,company")]
    AppliedToLinesContactCompany,

    [EnumMember(Value = "applied_to_lines,contact,company,accounting_period")]
    AppliedToLinesContactCompanyAccountingPeriod,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "company,accounting_period")]
    CompanyAccountingPeriod,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "contact,account")]
    ContactAccount,

    [EnumMember(Value = "contact,account,accounting_period")]
    ContactAccountAccountingPeriod,

    [EnumMember(Value = "contact,account,company")]
    ContactAccountCompany,

    [EnumMember(Value = "contact,account,company,accounting_period")]
    ContactAccountCompanyAccountingPeriod,

    [EnumMember(Value = "contact,accounting_period")]
    ContactAccountingPeriod,

    [EnumMember(Value = "contact,company")]
    ContactCompany,

    [EnumMember(Value = "contact,company,accounting_period")]
    ContactCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,

    [EnumMember(Value = "tracking_categories,account")]
    TrackingCategoriesAccount,

    [EnumMember(Value = "tracking_categories,account,accounting_period")]
    TrackingCategoriesAccountAccountingPeriod,

    [EnumMember(Value = "tracking_categories,account,company")]
    TrackingCategoriesAccountCompany,

    [EnumMember(Value = "tracking_categories,account,company,accounting_period")]
    TrackingCategoriesAccountCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,accounting_period")]
    TrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,applied_to_lines")]
    TrackingCategoriesAppliedToLines,

    [EnumMember(Value = "tracking_categories,applied_to_lines,account")]
    TrackingCategoriesAppliedToLinesAccount,

    [EnumMember(Value = "tracking_categories,applied_to_lines,account,accounting_period")]
    TrackingCategoriesAppliedToLinesAccountAccountingPeriod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,account,company")]
    TrackingCategoriesAppliedToLinesAccountCompany,

    [EnumMember(Value = "tracking_categories,applied_to_lines,account,company,accounting_period")]
    TrackingCategoriesAppliedToLinesAccountCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,accounting_period")]
    TrackingCategoriesAppliedToLinesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,company")]
    TrackingCategoriesAppliedToLinesCompany,

    [EnumMember(Value = "tracking_categories,applied_to_lines,company,accounting_period")]
    TrackingCategoriesAppliedToLinesCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact")]
    TrackingCategoriesAppliedToLinesContact,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,account")]
    TrackingCategoriesAppliedToLinesContactAccount,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,account,accounting_period")]
    TrackingCategoriesAppliedToLinesContactAccountAccountingPeriod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,account,company")]
    TrackingCategoriesAppliedToLinesContactAccountCompany,

    [EnumMember(
        Value = "tracking_categories,applied_to_lines,contact,account,company,accounting_period"
    )]
    TrackingCategoriesAppliedToLinesContactAccountCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,accounting_period")]
    TrackingCategoriesAppliedToLinesContactAccountingPeriod,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,company")]
    TrackingCategoriesAppliedToLinesContactCompany,

    [EnumMember(Value = "tracking_categories,applied_to_lines,contact,company,accounting_period")]
    TrackingCategoriesAppliedToLinesContactCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,company")]
    TrackingCategoriesCompany,

    [EnumMember(Value = "tracking_categories,company,accounting_period")]
    TrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact")]
    TrackingCategoriesContact,

    [EnumMember(Value = "tracking_categories,contact,account")]
    TrackingCategoriesContactAccount,

    [EnumMember(Value = "tracking_categories,contact,account,accounting_period")]
    TrackingCategoriesContactAccountAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact,account,company")]
    TrackingCategoriesContactAccountCompany,

    [EnumMember(Value = "tracking_categories,contact,account,company,accounting_period")]
    TrackingCategoriesContactAccountCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact,accounting_period")]
    TrackingCategoriesContactAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact,company")]
    TrackingCategoriesContactCompany,

    [EnumMember(Value = "tracking_categories,contact,company,accounting_period")]
    TrackingCategoriesContactCompanyAccountingPeriod,
}
