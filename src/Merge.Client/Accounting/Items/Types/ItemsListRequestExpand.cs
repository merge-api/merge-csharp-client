using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum ItemsListRequestExpand
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
