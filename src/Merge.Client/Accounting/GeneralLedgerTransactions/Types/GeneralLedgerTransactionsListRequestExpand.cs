using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<GeneralLedgerTransactionsListRequestExpand>))]
public enum GeneralLedgerTransactionsListRequestExpand
{
    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "company,accounting_period")]
    CompanyAccountingPeriod,

    [EnumMember(Value = "general_ledger_transaction_lines")]
    GeneralLedgerTransactionLines,

    [EnumMember(Value = "general_ledger_transaction_lines,accounting_period")]
    GeneralLedgerTransactionLinesAccountingPeriod,

    [EnumMember(Value = "general_ledger_transaction_lines,company")]
    GeneralLedgerTransactionLinesCompany,

    [EnumMember(Value = "general_ledger_transaction_lines,company,accounting_period")]
    GeneralLedgerTransactionLinesCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,

    [EnumMember(Value = "tracking_categories,accounting_period")]
    TrackingCategoriesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,company")]
    TrackingCategoriesCompany,

    [EnumMember(Value = "tracking_categories,company,accounting_period")]
    TrackingCategoriesCompanyAccountingPeriod,

    [EnumMember(Value = "tracking_categories,general_ledger_transaction_lines")]
    TrackingCategoriesGeneralLedgerTransactionLines,

    [EnumMember(Value = "tracking_categories,general_ledger_transaction_lines,accounting_period")]
    TrackingCategoriesGeneralLedgerTransactionLinesAccountingPeriod,

    [EnumMember(Value = "tracking_categories,general_ledger_transaction_lines,company")]
    TrackingCategoriesGeneralLedgerTransactionLinesCompany,

    [EnumMember(
        Value = "tracking_categories,general_ledger_transaction_lines,company,accounting_period"
    )]
    TrackingCategoriesGeneralLedgerTransactionLinesCompanyAccountingPeriod,
}
