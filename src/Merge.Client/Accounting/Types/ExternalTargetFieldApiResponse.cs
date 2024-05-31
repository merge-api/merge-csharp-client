using System.Text.Json.Serialization;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<ExternalTargetFieldApi>? Account { get; init; }

    [JsonPropertyName("AccountingAttachment")]
    public IEnumerable<ExternalTargetFieldApi>? AccountingAttachment { get; init; }

    [JsonPropertyName("BalanceSheet")]
    public IEnumerable<ExternalTargetFieldApi>? BalanceSheet { get; init; }

    [JsonPropertyName("CashFlowStatement")]
    public IEnumerable<ExternalTargetFieldApi>? CashFlowStatement { get; init; }

    [JsonPropertyName("CompanyInfo")]
    public IEnumerable<ExternalTargetFieldApi>? CompanyInfo { get; init; }

    [JsonPropertyName("Contact")]
    public IEnumerable<ExternalTargetFieldApi>? Contact { get; init; }

    [JsonPropertyName("IncomeStatement")]
    public IEnumerable<ExternalTargetFieldApi>? IncomeStatement { get; init; }

    [JsonPropertyName("CreditNote")]
    public IEnumerable<ExternalTargetFieldApi>? CreditNote { get; init; }

    [JsonPropertyName("Item")]
    public IEnumerable<ExternalTargetFieldApi>? Item { get; init; }

    [JsonPropertyName("PurchaseOrder")]
    public IEnumerable<ExternalTargetFieldApi>? PurchaseOrder { get; init; }

    [JsonPropertyName("TrackingCategory")]
    public IEnumerable<ExternalTargetFieldApi>? TrackingCategory { get; init; }

    [JsonPropertyName("JournalEntry")]
    public IEnumerable<ExternalTargetFieldApi>? JournalEntry { get; init; }

    [JsonPropertyName("TaxRate")]
    public IEnumerable<ExternalTargetFieldApi>? TaxRate { get; init; }

    [JsonPropertyName("Invoice")]
    public IEnumerable<ExternalTargetFieldApi>? Invoice { get; init; }

    [JsonPropertyName("Payment")]
    public IEnumerable<ExternalTargetFieldApi>? Payment { get; init; }

    [JsonPropertyName("Expense")]
    public IEnumerable<ExternalTargetFieldApi>? Expense { get; init; }

    [JsonPropertyName("VendorCredit")]
    public IEnumerable<ExternalTargetFieldApi>? VendorCredit { get; init; }

    [JsonPropertyName("Transaction")]
    public IEnumerable<ExternalTargetFieldApi>? Transaction { get; init; }

    [JsonPropertyName("GeneralLedgerTransaction")]
    public IEnumerable<ExternalTargetFieldApi>? GeneralLedgerTransaction { get; init; }
}
