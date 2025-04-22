using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<PurchaseOrdersRetrieveRequestExpand>))]
public enum PurchaseOrdersRetrieveRequestExpand
{
    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "accounting_period,payment_term")]
    AccountingPeriodPaymentTerm,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "company,accounting_period")]
    CompanyAccountingPeriod,

    [EnumMember(Value = "company,accounting_period,payment_term")]
    CompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "company,payment_term")]
    CompanyPaymentTerm,

    [EnumMember(Value = "delivery_address")]
    DeliveryAddress,

    [EnumMember(Value = "delivery_address,accounting_period")]
    DeliveryAddressAccountingPeriod,

    [EnumMember(Value = "delivery_address,accounting_period,payment_term")]
    DeliveryAddressAccountingPeriodPaymentTerm,

    [EnumMember(Value = "delivery_address,company")]
    DeliveryAddressCompany,

    [EnumMember(Value = "delivery_address,company,accounting_period")]
    DeliveryAddressCompanyAccountingPeriod,

    [EnumMember(Value = "delivery_address,company,accounting_period,payment_term")]
    DeliveryAddressCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "delivery_address,company,payment_term")]
    DeliveryAddressCompanyPaymentTerm,

    [EnumMember(Value = "delivery_address,payment_term")]
    DeliveryAddressPaymentTerm,

    [EnumMember(Value = "delivery_address,vendor")]
    DeliveryAddressVendor,

    [EnumMember(Value = "delivery_address,vendor,accounting_period")]
    DeliveryAddressVendorAccountingPeriod,

    [EnumMember(Value = "delivery_address,vendor,accounting_period,payment_term")]
    DeliveryAddressVendorAccountingPeriodPaymentTerm,

    [EnumMember(Value = "delivery_address,vendor,company")]
    DeliveryAddressVendorCompany,

    [EnumMember(Value = "delivery_address,vendor,company,accounting_period")]
    DeliveryAddressVendorCompanyAccountingPeriod,

    [EnumMember(Value = "delivery_address,vendor,company,accounting_period,payment_term")]
    DeliveryAddressVendorCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "delivery_address,vendor,company,payment_term")]
    DeliveryAddressVendorCompanyPaymentTerm,

    [EnumMember(Value = "delivery_address,vendor,payment_term")]
    DeliveryAddressVendorPaymentTerm,

    [EnumMember(Value = "line_items")]
    LineItems,

    [EnumMember(Value = "line_items,accounting_period")]
    LineItemsAccountingPeriod,

    [EnumMember(Value = "line_items,accounting_period,payment_term")]
    LineItemsAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,company")]
    LineItemsCompany,

    [EnumMember(Value = "line_items,company,accounting_period")]
    LineItemsCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,company,accounting_period,payment_term")]
    LineItemsCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,company,payment_term")]
    LineItemsCompanyPaymentTerm,

    [EnumMember(Value = "line_items,delivery_address")]
    LineItemsDeliveryAddress,

    [EnumMember(Value = "line_items,delivery_address,accounting_period")]
    LineItemsDeliveryAddressAccountingPeriod,

    [EnumMember(Value = "line_items,delivery_address,accounting_period,payment_term")]
    LineItemsDeliveryAddressAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,delivery_address,company")]
    LineItemsDeliveryAddressCompany,

    [EnumMember(Value = "line_items,delivery_address,company,accounting_period")]
    LineItemsDeliveryAddressCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,delivery_address,company,accounting_period,payment_term")]
    LineItemsDeliveryAddressCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,delivery_address,company,payment_term")]
    LineItemsDeliveryAddressCompanyPaymentTerm,

    [EnumMember(Value = "line_items,delivery_address,payment_term")]
    LineItemsDeliveryAddressPaymentTerm,

    [EnumMember(Value = "line_items,delivery_address,vendor")]
    LineItemsDeliveryAddressVendor,

    [EnumMember(Value = "line_items,delivery_address,vendor,accounting_period")]
    LineItemsDeliveryAddressVendorAccountingPeriod,

    [EnumMember(Value = "line_items,delivery_address,vendor,accounting_period,payment_term")]
    LineItemsDeliveryAddressVendorAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,delivery_address,vendor,company")]
    LineItemsDeliveryAddressVendorCompany,

    [EnumMember(Value = "line_items,delivery_address,vendor,company,accounting_period")]
    LineItemsDeliveryAddressVendorCompanyAccountingPeriod,

    [EnumMember(
        Value = "line_items,delivery_address,vendor,company,accounting_period,payment_term"
    )]
    LineItemsDeliveryAddressVendorCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,delivery_address,vendor,company,payment_term")]
    LineItemsDeliveryAddressVendorCompanyPaymentTerm,

    [EnumMember(Value = "line_items,delivery_address,vendor,payment_term")]
    LineItemsDeliveryAddressVendorPaymentTerm,

    [EnumMember(Value = "line_items,payment_term")]
    LineItemsPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories")]
    LineItemsTrackingCategories,

    [EnumMember(Value = "line_items,tracking_categories,accounting_period")]
    LineItemsTrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,accounting_period,payment_term")]
    LineItemsTrackingCategoriesAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,company")]
    LineItemsTrackingCategoriesCompany,

    [EnumMember(Value = "line_items,tracking_categories,company,accounting_period")]
    LineItemsTrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,company,accounting_period,payment_term")]
    LineItemsTrackingCategoriesCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,company,payment_term")]
    LineItemsTrackingCategoriesCompanyPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address")]
    LineItemsTrackingCategoriesDeliveryAddress,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,accounting_period")]
    LineItemsTrackingCategoriesDeliveryAddressAccountingPeriod,

    [EnumMember(
        Value = "line_items,tracking_categories,delivery_address,accounting_period,payment_term"
    )]
    LineItemsTrackingCategoriesDeliveryAddressAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,company")]
    LineItemsTrackingCategoriesDeliveryAddressCompany,

    [EnumMember(
        Value = "line_items,tracking_categories,delivery_address,company,accounting_period"
    )]
    LineItemsTrackingCategoriesDeliveryAddressCompanyAccountingPeriod,

    [EnumMember(
        Value = "line_items,tracking_categories,delivery_address,company,accounting_period,payment_term"
    )]
    LineItemsTrackingCategoriesDeliveryAddressCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,company,payment_term")]
    LineItemsTrackingCategoriesDeliveryAddressCompanyPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,payment_term")]
    LineItemsTrackingCategoriesDeliveryAddressPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,vendor")]
    LineItemsTrackingCategoriesDeliveryAddressVendor,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,vendor,accounting_period")]
    LineItemsTrackingCategoriesDeliveryAddressVendorAccountingPeriod,

    [EnumMember(
        Value = "line_items,tracking_categories,delivery_address,vendor,accounting_period,payment_term"
    )]
    LineItemsTrackingCategoriesDeliveryAddressVendorAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,vendor,company")]
    LineItemsTrackingCategoriesDeliveryAddressVendorCompany,

    [EnumMember(
        Value = "line_items,tracking_categories,delivery_address,vendor,company,accounting_period"
    )]
    LineItemsTrackingCategoriesDeliveryAddressVendorCompanyAccountingPeriod,

    [EnumMember(
        Value = "line_items,tracking_categories,delivery_address,vendor,company,accounting_period,payment_term"
    )]
    LineItemsTrackingCategoriesDeliveryAddressVendorCompanyAccountingPeriodPaymentTerm,

    [EnumMember(
        Value = "line_items,tracking_categories,delivery_address,vendor,company,payment_term"
    )]
    LineItemsTrackingCategoriesDeliveryAddressVendorCompanyPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,delivery_address,vendor,payment_term")]
    LineItemsTrackingCategoriesDeliveryAddressVendorPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,payment_term")]
    LineItemsTrackingCategoriesPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,vendor")]
    LineItemsTrackingCategoriesVendor,

    [EnumMember(Value = "line_items,tracking_categories,vendor,accounting_period")]
    LineItemsTrackingCategoriesVendorAccountingPeriod,

    [EnumMember(Value = "line_items,tracking_categories,vendor,accounting_period,payment_term")]
    LineItemsTrackingCategoriesVendorAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,vendor,company")]
    LineItemsTrackingCategoriesVendorCompany,

    [EnumMember(Value = "line_items,tracking_categories,vendor,company,accounting_period")]
    LineItemsTrackingCategoriesVendorCompanyAccountingPeriod,

    [EnumMember(
        Value = "line_items,tracking_categories,vendor,company,accounting_period,payment_term"
    )]
    LineItemsTrackingCategoriesVendorCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,vendor,company,payment_term")]
    LineItemsTrackingCategoriesVendorCompanyPaymentTerm,

    [EnumMember(Value = "line_items,tracking_categories,vendor,payment_term")]
    LineItemsTrackingCategoriesVendorPaymentTerm,

    [EnumMember(Value = "line_items,vendor")]
    LineItemsVendor,

    [EnumMember(Value = "line_items,vendor,accounting_period")]
    LineItemsVendorAccountingPeriod,

    [EnumMember(Value = "line_items,vendor,accounting_period,payment_term")]
    LineItemsVendorAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,vendor,company")]
    LineItemsVendorCompany,

    [EnumMember(Value = "line_items,vendor,company,accounting_period")]
    LineItemsVendorCompanyAccountingPeriod,

    [EnumMember(Value = "line_items,vendor,company,accounting_period,payment_term")]
    LineItemsVendorCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "line_items,vendor,company,payment_term")]
    LineItemsVendorCompanyPaymentTerm,

    [EnumMember(Value = "line_items,vendor,payment_term")]
    LineItemsVendorPaymentTerm,

    [EnumMember(Value = "payment_term")]
    PaymentTerm,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,

    [EnumMember(Value = "tracking_categories,accounting_period")]
    TrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,accounting_period,payment_term")]
    TrackingCategoriesAccountingPeriodPaymentTerm,

    [EnumMember(Value = "tracking_categories,company")]
    TrackingCategoriesCompany,

    [EnumMember(Value = "tracking_categories,company,accounting_period")]
    TrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,company,accounting_period,payment_term")]
    TrackingCategoriesCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "tracking_categories,company,payment_term")]
    TrackingCategoriesCompanyPaymentTerm,

    [EnumMember(Value = "tracking_categories,delivery_address")]
    TrackingCategoriesDeliveryAddress,

    [EnumMember(Value = "tracking_categories,delivery_address,accounting_period")]
    TrackingCategoriesDeliveryAddressAccountingPeriod,

    [EnumMember(Value = "tracking_categories,delivery_address,accounting_period,payment_term")]
    TrackingCategoriesDeliveryAddressAccountingPeriodPaymentTerm,

    [EnumMember(Value = "tracking_categories,delivery_address,company")]
    TrackingCategoriesDeliveryAddressCompany,

    [EnumMember(Value = "tracking_categories,delivery_address,company,accounting_period")]
    TrackingCategoriesDeliveryAddressCompanyAccountingPeriod,

    [EnumMember(
        Value = "tracking_categories,delivery_address,company,accounting_period,payment_term"
    )]
    TrackingCategoriesDeliveryAddressCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "tracking_categories,delivery_address,company,payment_term")]
    TrackingCategoriesDeliveryAddressCompanyPaymentTerm,

    [EnumMember(Value = "tracking_categories,delivery_address,payment_term")]
    TrackingCategoriesDeliveryAddressPaymentTerm,

    [EnumMember(Value = "tracking_categories,delivery_address,vendor")]
    TrackingCategoriesDeliveryAddressVendor,

    [EnumMember(Value = "tracking_categories,delivery_address,vendor,accounting_period")]
    TrackingCategoriesDeliveryAddressVendorAccountingPeriod,

    [EnumMember(
        Value = "tracking_categories,delivery_address,vendor,accounting_period,payment_term"
    )]
    TrackingCategoriesDeliveryAddressVendorAccountingPeriodPaymentTerm,

    [EnumMember(Value = "tracking_categories,delivery_address,vendor,company")]
    TrackingCategoriesDeliveryAddressVendorCompany,

    [EnumMember(Value = "tracking_categories,delivery_address,vendor,company,accounting_period")]
    TrackingCategoriesDeliveryAddressVendorCompanyAccountingPeriod,

    [EnumMember(
        Value = "tracking_categories,delivery_address,vendor,company,accounting_period,payment_term"
    )]
    TrackingCategoriesDeliveryAddressVendorCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "tracking_categories,delivery_address,vendor,company,payment_term")]
    TrackingCategoriesDeliveryAddressVendorCompanyPaymentTerm,

    [EnumMember(Value = "tracking_categories,delivery_address,vendor,payment_term")]
    TrackingCategoriesDeliveryAddressVendorPaymentTerm,

    [EnumMember(Value = "tracking_categories,payment_term")]
    TrackingCategoriesPaymentTerm,

    [EnumMember(Value = "tracking_categories,vendor")]
    TrackingCategoriesVendor,

    [EnumMember(Value = "tracking_categories,vendor,accounting_period")]
    TrackingCategoriesVendorAccountingPeriod,

    [EnumMember(Value = "tracking_categories,vendor,accounting_period,payment_term")]
    TrackingCategoriesVendorAccountingPeriodPaymentTerm,

    [EnumMember(Value = "tracking_categories,vendor,company")]
    TrackingCategoriesVendorCompany,

    [EnumMember(Value = "tracking_categories,vendor,company,accounting_period")]
    TrackingCategoriesVendorCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,vendor,company,accounting_period,payment_term")]
    TrackingCategoriesVendorCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "tracking_categories,vendor,company,payment_term")]
    TrackingCategoriesVendorCompanyPaymentTerm,

    [EnumMember(Value = "tracking_categories,vendor,payment_term")]
    TrackingCategoriesVendorPaymentTerm,

    [EnumMember(Value = "vendor")]
    Vendor,

    [EnumMember(Value = "vendor,accounting_period")]
    VendorAccountingPeriod,

    [EnumMember(Value = "vendor,accounting_period,payment_term")]
    VendorAccountingPeriodPaymentTerm,

    [EnumMember(Value = "vendor,company")]
    VendorCompany,

    [EnumMember(Value = "vendor,company,accounting_period")]
    VendorCompanyAccountingPeriod,

    [EnumMember(Value = "vendor,company,accounting_period,payment_term")]
    VendorCompanyAccountingPeriodPaymentTerm,

    [EnumMember(Value = "vendor,company,payment_term")]
    VendorCompanyPaymentTerm,

    [EnumMember(Value = "vendor,payment_term")]
    VendorPaymentTerm,
}
