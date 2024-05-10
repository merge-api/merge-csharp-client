using System.Text.Json.Serialization;
using Merge.Client.Accounting;

namespace Merge.Client.Accounting;

public class ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Account")]
    public List<ExternalTargetFieldApi>? Account { get; init; }

    [JsonPropertyName("AccountingAttachment")]
    public List<ExternalTargetFieldApi>? AccountingAttachment { get; init; }

    [JsonPropertyName("BalanceSheet")]
    public List<ExternalTargetFieldApi>? BalanceSheet { get; init; }

    [JsonPropertyName("CashFlowStatement")]
    public List<ExternalTargetFieldApi>? CashFlowStatement { get; init; }

    [JsonPropertyName("CompanyInfo")]
    public List<ExternalTargetFieldApi>? CompanyInfo { get; init; }

    [JsonPropertyName("Contact")]
    public List<ExternalTargetFieldApi>? Contact { get; init; }

    [JsonPropertyName("IncomeStatement")]
    public List<ExternalTargetFieldApi>? IncomeStatement { get; init; }

    [JsonPropertyName("CreditNote")]
    public List<ExternalTargetFieldApi>? CreditNote { get; init; }

    [JsonPropertyName("Item")]
    public List<ExternalTargetFieldApi>? Item { get; init; }

    [JsonPropertyName("PurchaseOrder")]
    public List<ExternalTargetFieldApi>? PurchaseOrder { get; init; }

    [JsonPropertyName("TrackingCategory")]
    public List<ExternalTargetFieldApi>? TrackingCategory { get; init; }

    [JsonPropertyName("JournalEntry")]
    public List<ExternalTargetFieldApi>? JournalEntry { get; init; }

    [JsonPropertyName("TaxRate")]
    public List<ExternalTargetFieldApi>? TaxRate { get; init; }

    [JsonPropertyName("Invoice")]
    public List<ExternalTargetFieldApi>? Invoice { get; init; }

    [JsonPropertyName("Payment")]
    public List<ExternalTargetFieldApi>? Payment { get; init; }

    [JsonPropertyName("Expense")]
    public List<ExternalTargetFieldApi>? Expense { get; init; }

    [JsonPropertyName("VendorCredit")]
    public List<ExternalTargetFieldApi>? VendorCredit { get; init; }

    [JsonPropertyName("Transaction")]
    public List<ExternalTargetFieldApi>? Transaction { get; init; }

    [JsonPropertyName("GeneralLedgerTransaction")]
    public List<ExternalTargetFieldApi>? GeneralLedgerTransaction { get; init; }
}
