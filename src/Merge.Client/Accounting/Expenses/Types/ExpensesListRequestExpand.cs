using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ExpensesListRequestExpand>))]
public enum ExpensesListRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,accounting_period")]
    AccountAccountingPeriod,

    [EnumMember(Value = "account,company")]
    AccountCompany,

    [EnumMember(Value = "account,company,accounting_period")]
    AccountCompanyAccountingPeriod,

    [EnumMember(Value = "account,company,employee")]
    AccountCompanyEmployee,

    [EnumMember(Value = "account,company,employee,accounting_period")]
    AccountCompanyEmployeeAccountingPeriod,

    [EnumMember(Value = "account,contact")]
    AccountContact,

    [EnumMember(Value = "account,contact,accounting_period")]
    AccountContactAccountingPeriod,

    [EnumMember(Value = "account,contact,company")]
    AccountContactCompany,

    [EnumMember(Value = "account,contact,company,accounting_period")]
    AccountContactCompanyAccountingPeriod,

    [EnumMember(Value = "account,contact,company,employee")]
    AccountContactCompanyEmployee,

    [EnumMember(Value = "account,contact,company,employee,accounting_period")]
    AccountContactCompanyEmployeeAccountingPeriod,

    [EnumMember(Value = "account,contact,employee")]
    AccountContactEmployee,

    [EnumMember(Value = "account,contact,employee,accounting_period")]
    AccountContactEmployeeAccountingPeriod,

    [EnumMember(Value = "account,employee")]
    AccountEmployee,

    [EnumMember(Value = "account,employee,accounting_period")]
    AccountEmployeeAccountingPeriod,

    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "company,accounting_period")]
    CompanyAccountingPeriod,

    [EnumMember(Value = "company,employee")]
    CompanyEmployee,

    [EnumMember(Value = "company,employee,accounting_period")]
    CompanyEmployeeAccountingPeriod,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "contact,accounting_period")]
    ContactAccountingPeriod,

    [EnumMember(Value = "contact,company")]
    ContactCompany,

    [EnumMember(Value = "contact,company,accounting_period")]
    ContactCompanyAccountingPeriod,

    [EnumMember(Value = "contact,company,employee")]
    ContactCompanyEmployee,

    [EnumMember(Value = "contact,company,employee,accounting_period")]
    ContactCompanyEmployeeAccountingPeriod,

    [EnumMember(Value = "contact,employee")]
    ContactEmployee,

    [EnumMember(Value = "contact,employee,accounting_period")]
    ContactEmployeeAccountingPeriod,

    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "employee,accounting_period")]
    EmployeeAccountingPeriod,

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

    [EnumMember(Value = "tracking_categories,account,company,employee")]
    TrackingCategoriesAccountCompanyEmployee,

    [EnumMember(Value = "tracking_categories,account,company,employee,accounting_period")]
    TrackingCategoriesAccountCompanyEmployeeAccountingPeriod,

    [EnumMember(Value = "tracking_categories,account,contact")]
    TrackingCategoriesAccountContact,

    [EnumMember(Value = "tracking_categories,account,contact,accounting_period")]
    TrackingCategoriesAccountContactAccountingPeriod,

    [EnumMember(Value = "tracking_categories,account,contact,company")]
    TrackingCategoriesAccountContactCompany,

    [EnumMember(Value = "tracking_categories,account,contact,company,accounting_period")]
    TrackingCategoriesAccountContactCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,account,contact,company,employee")]
    TrackingCategoriesAccountContactCompanyEmployee,

    [EnumMember(Value = "tracking_categories,account,contact,company,employee,accounting_period")]
    TrackingCategoriesAccountContactCompanyEmployeeAccountingPeriod,

    [EnumMember(Value = "tracking_categories,account,contact,employee")]
    TrackingCategoriesAccountContactEmployee,

    [EnumMember(Value = "tracking_categories,account,contact,employee,accounting_period")]
    TrackingCategoriesAccountContactEmployeeAccountingPeriod,

    [EnumMember(Value = "tracking_categories,account,employee")]
    TrackingCategoriesAccountEmployee,

    [EnumMember(Value = "tracking_categories,account,employee,accounting_period")]
    TrackingCategoriesAccountEmployeeAccountingPeriod,

    [EnumMember(Value = "tracking_categories,accounting_period")]
    TrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,company")]
    TrackingCategoriesCompany,

    [EnumMember(Value = "tracking_categories,company,accounting_period")]
    TrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,company,employee")]
    TrackingCategoriesCompanyEmployee,

    [EnumMember(Value = "tracking_categories,company,employee,accounting_period")]
    TrackingCategoriesCompanyEmployeeAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact")]
    TrackingCategoriesContact,

    [EnumMember(Value = "tracking_categories,contact,accounting_period")]
    TrackingCategoriesContactAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact,company")]
    TrackingCategoriesContactCompany,

    [EnumMember(Value = "tracking_categories,contact,company,accounting_period")]
    TrackingCategoriesContactCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact,company,employee")]
    TrackingCategoriesContactCompanyEmployee,

    [EnumMember(Value = "tracking_categories,contact,company,employee,accounting_period")]
    TrackingCategoriesContactCompanyEmployeeAccountingPeriod,

    [EnumMember(Value = "tracking_categories,contact,employee")]
    TrackingCategoriesContactEmployee,

    [EnumMember(Value = "tracking_categories,contact,employee,accounting_period")]
    TrackingCategoriesContactEmployeeAccountingPeriod,

    [EnumMember(Value = "tracking_categories,employee")]
    TrackingCategoriesEmployee,

    [EnumMember(Value = "tracking_categories,employee,accounting_period")]
    TrackingCategoriesEmployeeAccountingPeriod,
}
