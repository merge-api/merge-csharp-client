using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<GeneralLedgerTransactionsRetrieveRequestExpandItem>))]
public enum GeneralLedgerTransactionsRetrieveRequestExpandItem
{
    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "general_ledger_transaction_lines")]
    GeneralLedgerTransactionLines,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,
}
