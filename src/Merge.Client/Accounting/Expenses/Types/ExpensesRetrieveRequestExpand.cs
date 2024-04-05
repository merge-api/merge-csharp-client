using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum ExpensesRetrieveRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,accounting_period")]
    AccountAccountingPeriod,

    [EnumMember(Value = "account,company")]
    AccountCompany,

    [EnumMember(Value = "account,company,accounting_period")]
    AccountCompanyAccountingPeriod,

    [EnumMember(Value = "account,contact")]
    AccountContact,

    [EnumMember(Value = "account,contact,accounting_period")]
    AccountContactAccountingPeriod,

    [EnumMember(Value = "account,contact,company")]
    AccountContactCompany,

    [EnumMember(Value = "account,contact,company,accounting_period")]
    AccountContactCompanyAccountingPeriod,

    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

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

    [EnumMember(Value = "tracking_categories,account,contact")]
    TrackingCategoriesAccountContact,

    [EnumMember(Value = "tracking_categories,account,contact,accounting_period")]
    TrackingCategoriesAccountContactAccountingPeriod,

    [EnumMember(Value = "tracking_categories,account,contact,company")]
    TrackingCategoriesAccountContactCompany,

    [EnumMember(Value = "tracking_categories,account,contact,company,accounting_period")]
    TrackingCategoriesAccountContactCompanyAccountingPeriod,

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
