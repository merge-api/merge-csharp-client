using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<ItemsListRequestExpandItem>))]
public enum ItemsListRequestExpandItem
{
    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "purchase_account")]
    PurchaseAccount,

    [EnumMember(Value = "purchase_tax_rate")]
    PurchaseTaxRate,

    [EnumMember(Value = "sales_account")]
    SalesAccount,

    [EnumMember(Value = "sales_tax_rate")]
    SalesTaxRate,
}
