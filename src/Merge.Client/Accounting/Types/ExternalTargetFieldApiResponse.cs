using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public record ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<ExternalTargetFieldApi>? Account { get; set; }

    [JsonPropertyName("AccountingAttachment")]
    public IEnumerable<ExternalTargetFieldApi>? AccountingAttachment { get; set; }

    [JsonPropertyName("BalanceSheet")]
    public IEnumerable<ExternalTargetFieldApi>? BalanceSheet { get; set; }

    [JsonPropertyName("CashFlowStatement")]
    public IEnumerable<ExternalTargetFieldApi>? CashFlowStatement { get; set; }

    [JsonPropertyName("CompanyInfo")]
    public IEnumerable<ExternalTargetFieldApi>? CompanyInfo { get; set; }

    [JsonPropertyName("Contact")]
    public IEnumerable<ExternalTargetFieldApi>? Contact { get; set; }

    [JsonPropertyName("IncomeStatement")]
    public IEnumerable<ExternalTargetFieldApi>? IncomeStatement { get; set; }

    [JsonPropertyName("CreditNote")]
    public IEnumerable<ExternalTargetFieldApi>? CreditNote { get; set; }

    [JsonPropertyName("Item")]
    public IEnumerable<ExternalTargetFieldApi>? Item { get; set; }

    [JsonPropertyName("PurchaseOrder")]
    public IEnumerable<ExternalTargetFieldApi>? PurchaseOrder { get; set; }

    [JsonPropertyName("TrackingCategory")]
    public IEnumerable<ExternalTargetFieldApi>? TrackingCategory { get; set; }

    [JsonPropertyName("JournalEntry")]
    public IEnumerable<ExternalTargetFieldApi>? JournalEntry { get; set; }

    [JsonPropertyName("TaxRate")]
    public IEnumerable<ExternalTargetFieldApi>? TaxRate { get; set; }

    [JsonPropertyName("Invoice")]
    public IEnumerable<ExternalTargetFieldApi>? Invoice { get; set; }

    [JsonPropertyName("Payment")]
    public IEnumerable<ExternalTargetFieldApi>? Payment { get; set; }

    [JsonPropertyName("Expense")]
    public IEnumerable<ExternalTargetFieldApi>? Expense { get; set; }

    [JsonPropertyName("VendorCredit")]
    public IEnumerable<ExternalTargetFieldApi>? VendorCredit { get; set; }

    [JsonPropertyName("Transaction")]
    public IEnumerable<ExternalTargetFieldApi>? Transaction { get; set; }

    [JsonPropertyName("AccountingPeriod")]
    public IEnumerable<ExternalTargetFieldApi>? AccountingPeriod { get; set; }

    [JsonPropertyName("GeneralLedgerTransaction")]
    public IEnumerable<ExternalTargetFieldApi>? GeneralLedgerTransaction { get; set; }

    [JsonPropertyName("BankFeedAccount")]
    public IEnumerable<ExternalTargetFieldApi>? BankFeedAccount { get; set; }

    [JsonPropertyName("Employee")]
    public IEnumerable<ExternalTargetFieldApi>? Employee { get; set; }

    [JsonPropertyName("PaymentMethod")]
    public IEnumerable<ExternalTargetFieldApi>? PaymentMethod { get; set; }

    [JsonPropertyName("PaymentTerm")]
    public IEnumerable<ExternalTargetFieldApi>? PaymentTerm { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
