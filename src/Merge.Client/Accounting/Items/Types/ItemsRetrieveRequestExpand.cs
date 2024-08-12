using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ItemsRetrieveRequestExpand>))]
public enum ItemsRetrieveRequestExpand
{
    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "purchase_account")]
    PurchaseAccount,

    [EnumMember(Value = "purchase_account,company")]
    PurchaseAccountCompany,

    [EnumMember(Value = "purchase_account,sales_account")]
    PurchaseAccountSalesAccount,

    [EnumMember(Value = "purchase_account,sales_account,company")]
    PurchaseAccountSalesAccountCompany,

    [EnumMember(Value = "sales_account")]
    SalesAccount,

    [EnumMember(Value = "sales_account,company")]
    SalesAccountCompany
}
