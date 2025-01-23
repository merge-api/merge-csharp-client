using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ItemsListRequestExpand>))]
public enum ItemsListRequestExpand
{
    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "company,purchase_tax_rate")]
    CompanyPurchaseTaxRate,

    [EnumMember(Value = "company,sales_tax_rate")]
    CompanySalesTaxRate,

    [EnumMember(Value = "company,sales_tax_rate,purchase_tax_rate")]
    CompanySalesTaxRatePurchaseTaxRate,

    [EnumMember(Value = "purchase_account")]
    PurchaseAccount,

    [EnumMember(Value = "purchase_account,company")]
    PurchaseAccountCompany,

    [EnumMember(Value = "purchase_account,company,purchase_tax_rate")]
    PurchaseAccountCompanyPurchaseTaxRate,

    [EnumMember(Value = "purchase_account,company,sales_tax_rate")]
    PurchaseAccountCompanySalesTaxRate,

    [EnumMember(Value = "purchase_account,company,sales_tax_rate,purchase_tax_rate")]
    PurchaseAccountCompanySalesTaxRatePurchaseTaxRate,

    [EnumMember(Value = "purchase_account,purchase_tax_rate")]
    PurchaseAccountPurchaseTaxRate,

    [EnumMember(Value = "purchase_account,sales_account")]
    PurchaseAccountSalesAccount,

    [EnumMember(Value = "purchase_account,sales_account,company")]
    PurchaseAccountSalesAccountCompany,

    [EnumMember(Value = "purchase_account,sales_account,company,purchase_tax_rate")]
    PurchaseAccountSalesAccountCompanyPurchaseTaxRate,

    [EnumMember(Value = "purchase_account,sales_account,company,sales_tax_rate")]
    PurchaseAccountSalesAccountCompanySalesTaxRate,

    [EnumMember(Value = "purchase_account,sales_account,company,sales_tax_rate,purchase_tax_rate")]
    PurchaseAccountSalesAccountCompanySalesTaxRatePurchaseTaxRate,

    [EnumMember(Value = "purchase_account,sales_account,purchase_tax_rate")]
    PurchaseAccountSalesAccountPurchaseTaxRate,

    [EnumMember(Value = "purchase_account,sales_account,sales_tax_rate")]
    PurchaseAccountSalesAccountSalesTaxRate,

    [EnumMember(Value = "purchase_account,sales_account,sales_tax_rate,purchase_tax_rate")]
    PurchaseAccountSalesAccountSalesTaxRatePurchaseTaxRate,

    [EnumMember(Value = "purchase_account,sales_tax_rate")]
    PurchaseAccountSalesTaxRate,

    [EnumMember(Value = "purchase_account,sales_tax_rate,purchase_tax_rate")]
    PurchaseAccountSalesTaxRatePurchaseTaxRate,

    [EnumMember(Value = "purchase_tax_rate")]
    PurchaseTaxRate,

    [EnumMember(Value = "sales_account")]
    SalesAccount,

    [EnumMember(Value = "sales_account,company")]
    SalesAccountCompany,

    [EnumMember(Value = "sales_account,company,purchase_tax_rate")]
    SalesAccountCompanyPurchaseTaxRate,

    [EnumMember(Value = "sales_account,company,sales_tax_rate")]
    SalesAccountCompanySalesTaxRate,

    [EnumMember(Value = "sales_account,company,sales_tax_rate,purchase_tax_rate")]
    SalesAccountCompanySalesTaxRatePurchaseTaxRate,

    [EnumMember(Value = "sales_account,purchase_tax_rate")]
    SalesAccountPurchaseTaxRate,

    [EnumMember(Value = "sales_account,sales_tax_rate")]
    SalesAccountSalesTaxRate,

    [EnumMember(Value = "sales_account,sales_tax_rate,purchase_tax_rate")]
    SalesAccountSalesTaxRatePurchaseTaxRate,

    [EnumMember(Value = "sales_tax_rate")]
    SalesTaxRate,

    [EnumMember(Value = "sales_tax_rate,purchase_tax_rate")]
    SalesTaxRatePurchaseTaxRate,
}
