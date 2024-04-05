using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum VendorCreditsListRequestExpand
{
    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "company,accounting_period")]
    CompanyAccountingPeriod,

    [EnumMember(Value = "lines")]
    Lines,

    [EnumMember(Value = "lines,accounting_period")]
    LinesAccountingPeriod,

    [EnumMember(Value = "lines,company")]
    LinesCompany,

    [EnumMember(Value = "lines,company,accounting_period")]
    LinesCompanyAccountingPeriod,

    [EnumMember(Value = "lines,tracking_categories")]
    LinesTrackingCategories,

    [EnumMember(Value = "lines,tracking_categories,accounting_period")]
    LinesTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "lines,tracking_categories,company")]
    LinesTrackingCategoriesCompany,

    [EnumMember(Value = "lines,tracking_categories,company,accounting_period")]
    LinesTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "lines,tracking_categories,vendor")]
    LinesTrackingCategoriesVendor,

    [EnumMember(Value = "lines,tracking_categories,vendor,accounting_period")]
    LinesTrackingCategoriesVendorAccountingPeriod,

    [EnumMember(Value = "lines,tracking_categories,vendor,company")]
    LinesTrackingCategoriesVendorCompany,

    [EnumMember(Value = "lines,tracking_categories,vendor,company,accounting_period")]
    LinesTrackingCategoriesVendorCompanyAccountingPeriod,

    [EnumMember(Value = "lines,vendor")]
    LinesVendor,

    [EnumMember(Value = "lines,vendor,accounting_period")]
    LinesVendorAccountingPeriod,

    [EnumMember(Value = "lines,vendor,company")]
    LinesVendorCompany,

    [EnumMember(Value = "lines,vendor,company,accounting_period")]
    LinesVendorCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,

    [EnumMember(Value = "tracking_categories,accounting_period")]
    TrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,company")]
    TrackingCategoriesCompany,

    [EnumMember(Value = "tracking_categories,company,accounting_period")]
    TrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,vendor")]
    TrackingCategoriesVendor,

    [EnumMember(Value = "tracking_categories,vendor,accounting_period")]
    TrackingCategoriesVendorAccountingPeriod,

    [EnumMember(Value = "tracking_categories,vendor,company")]
    TrackingCategoriesVendorCompany,

    [EnumMember(Value = "tracking_categories,vendor,company,accounting_period")]
    TrackingCategoriesVendorCompanyAccountingPeriod,

    [EnumMember(Value = "vendor")]
    Vendor,

    [EnumMember(Value = "vendor,accounting_period")]
    VendorAccountingPeriod,

    [EnumMember(Value = "vendor,company")]
    VendorCompany,

    [EnumMember(Value = "vendor,company,accounting_period")]
    VendorCompanyAccountingPeriod
}
