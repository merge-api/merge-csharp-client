using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum PurchaseOrdersListRequestExpand
{
    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "company,accounting_period")]
    CompanyAccountingPeriod,

    [EnumMember(Value = "delivery_address")]
    DeliveryAddress,

    [EnumMember(Value = "delivery_address,accounting_period")]
    DeliveryAddressAccountingPeriod,

    [EnumMember(Value = "delivery_address,company")]
    DeliveryAddressCompany,

    [EnumMember(Value = "delivery_address,company,accounting_period")]
    DeliveryAddressCompanyAccountingPeriod,

    [EnumMember(Value = "delivery_address,vendor")]
    DeliveryAddressVendor,

    [EnumMember(Value = "delivery_address,vendor,accounting_period")]
    DeliveryAddressVendorAccountingPeriod,

    [EnumMember(Value = "delivery_address,vendor,company")]
    DeliveryAddressVendorCompany,

    [EnumMember(Value = "delivery_address,vendor,company,accounting_period")]
    DeliveryAddressVendorCompanyAccountingPeriod,

    [EnumMember(Value = "line_items")]
    LineItems,

    [EnumMember(Value = "line_items,accounting_period")]
    LineItemsAccountingPeriod,

    [EnumMember(Value = "line_items,company")]
    LineItemsCompany,

    [EnumMember(Value = "line_items,company,accounting_period")]
    LineItemsCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,delivery_address")]
    LineItemsDeliveryAddress,

    [EnumMember(Value = "line_items,delivery_address,accounting_period")]
    LineItemsDeliveryAddressAccountingPeriod,

    [EnumMember(Value = "line_items,delivery_address,company")]
    LineItemsDeliveryAddressCompany,

    [EnumMember(Value = "line_items,delivery_address,company,accounting_period")]
    LineItemsDeliveryAddressCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,delivery_address,vendor")]
    LineItemsDeliveryAddressVendor,

    [EnumMember(Value = "line_items,delivery_address,vendor,accounting_period")]
    LineItemsDeliveryAddressVendorAccountingPeriod,

    [EnumMember(Value = "line_items,delivery_address,vendor,company")]
    LineItemsDeliveryAddressVendorCompany,

    [EnumMember(Value = "line_items,delivery_address,vendor,company,accounting_period")]
    LineItemsDeliveryAddressVendorCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories")]
    LineItemsTrackingCategories,

    [EnumMember(Value = "line_items,tracking_categories,accounting_period")]
    LineItemsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,company")]
    LineItemsTrackingCategoriesCompany,

    [EnumMember(Value = "line_items,tracking_categories,company,accounting_period")]
    LineItemsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address")]
    LineItemsTrackingCategoriesDeliveryAddress,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,accounting_period")]
    LineItemsTrackingCategoriesDeliveryAddressAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,company")]
    LineItemsTrackingCategoriesDeliveryAddressCompany,

    [EnumMember(
        Value = "line_items,tracking_categories,delivery_address,company,accounting_period"
    )]
    LineItemsTrackingCategoriesDeliveryAddressCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,vendor")]
    LineItemsTrackingCategoriesDeliveryAddressVendor,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,vendor,accounting_period")]
    LineItemsTrackingCategoriesDeliveryAddressVendorAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,vendor,company")]
    LineItemsTrackingCategoriesDeliveryAddressVendorCompany,

    [EnumMember(
        Value = "line_items,tracking_categories,delivery_address,vendor,company,accounting_period"
    )]
    LineItemsTrackingCategoriesDeliveryAddressVendorCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,vendor")]
    LineItemsTrackingCategoriesVendor,

    [EnumMember(Value = "line_items,tracking_categories,vendor,accounting_period")]
    LineItemsTrackingCategoriesVendorAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,vendor,company")]
    LineItemsTrackingCategoriesVendorCompany,

    [EnumMember(Value = "line_items,tracking_categories,vendor,company,accounting_period")]
    LineItemsTrackingCategoriesVendorCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,vendor")]
    LineItemsVendor,

    [EnumMember(Value = "line_items,vendor,accounting_period")]
    LineItemsVendorAccountingPeriod,

    [EnumMember(Value = "line_items,vendor,company")]
    LineItemsVendorCompany,

    [EnumMember(Value = "line_items,vendor,company,accounting_period")]
    LineItemsVendorCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,

    [EnumMember(Value = "tracking_categories,accounting_period")]
    TrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,company")]
    TrackingCategoriesCompany,

    [EnumMember(Value = "tracking_categories,company,accounting_period")]
    TrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,delivery_address")]
    TrackingCategoriesDeliveryAddress,

    [EnumMember(Value = "tracking_categories,delivery_address,accounting_period")]
    TrackingCategoriesDeliveryAddressAccountingPeriod,

    [EnumMember(Value = "tracking_categories,delivery_address,company")]
    TrackingCategoriesDeliveryAddressCompany,

    [EnumMember(Value = "tracking_categories,delivery_address,company,accounting_period")]
    TrackingCategoriesDeliveryAddressCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,delivery_address,vendor")]
    TrackingCategoriesDeliveryAddressVendor,

    [EnumMember(Value = "tracking_categories,delivery_address,vendor,accounting_period")]
    TrackingCategoriesDeliveryAddressVendorAccountingPeriod,

    [EnumMember(Value = "tracking_categories,delivery_address,vendor,company")]
    TrackingCategoriesDeliveryAddressVendorCompany,

    [EnumMember(Value = "tracking_categories,delivery_address,vendor,company,accounting_period")]
    TrackingCategoriesDeliveryAddressVendorCompanyAccountingPeriod,

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
