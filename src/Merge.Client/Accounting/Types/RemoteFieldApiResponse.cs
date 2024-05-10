using System.Text.Json.Serialization;
using Merge.Client.Accounting;

namespace Merge.Client.Accounting;

public class RemoteFieldApiResponse
{
    [JsonPropertyName("Account")]
    public List<RemoteFieldApi>? Account { get; init; }

    [JsonPropertyName("AccountingAttachment")]
    public List<RemoteFieldApi>? AccountingAttachment { get; init; }

    [JsonPropertyName("BalanceSheet")]
    public List<RemoteFieldApi>? BalanceSheet { get; init; }

    [JsonPropertyName("CashFlowStatement")]
    public List<RemoteFieldApi>? CashFlowStatement { get; init; }

    [JsonPropertyName("CompanyInfo")]
    public List<RemoteFieldApi>? CompanyInfo { get; init; }

    [JsonPropertyName("Contact")]
    public List<RemoteFieldApi>? Contact { get; init; }

    [JsonPropertyName("IncomeStatement")]
    public List<RemoteFieldApi>? IncomeStatement { get; init; }

    [JsonPropertyName("CreditNote")]
    public List<RemoteFieldApi>? CreditNote { get; init; }

    [JsonPropertyName("Item")]
    public List<RemoteFieldApi>? Item { get; init; }

    [JsonPropertyName("PurchaseOrder")]
    public List<RemoteFieldApi>? PurchaseOrder { get; init; }

    [JsonPropertyName("TrackingCategory")]
    public List<RemoteFieldApi>? TrackingCategory { get; init; }

    [JsonPropertyName("JournalEntry")]
    public List<RemoteFieldApi>? JournalEntry { get; init; }

    [JsonPropertyName("TaxRate")]
    public List<RemoteFieldApi>? TaxRate { get; init; }

    [JsonPropertyName("Invoice")]
    public List<RemoteFieldApi>? Invoice { get; init; }

    [JsonPropertyName("Payment")]
    public List<RemoteFieldApi>? Payment { get; init; }

    [JsonPropertyName("Expense")]
    public List<RemoteFieldApi>? Expense { get; init; }

    [JsonPropertyName("VendorCredit")]
    public List<RemoteFieldApi>? VendorCredit { get; init; }

    [JsonPropertyName("Transaction")]
    public List<RemoteFieldApi>? Transaction { get; init; }

    [JsonPropertyName("GeneralLedgerTransaction")]
    public List<RemoteFieldApi>? GeneralLedgerTransaction { get; init; }
}
