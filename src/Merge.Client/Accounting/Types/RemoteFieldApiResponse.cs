using System.Text.Json.Serialization;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class RemoteFieldApiResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<RemoteFieldApi>? Account { get; init; }

    [JsonPropertyName("AccountingAttachment")]
    public IEnumerable<RemoteFieldApi>? AccountingAttachment { get; init; }

    [JsonPropertyName("BalanceSheet")]
    public IEnumerable<RemoteFieldApi>? BalanceSheet { get; init; }

    [JsonPropertyName("CashFlowStatement")]
    public IEnumerable<RemoteFieldApi>? CashFlowStatement { get; init; }

    [JsonPropertyName("CompanyInfo")]
    public IEnumerable<RemoteFieldApi>? CompanyInfo { get; init; }

    [JsonPropertyName("Contact")]
    public IEnumerable<RemoteFieldApi>? Contact { get; init; }

    [JsonPropertyName("IncomeStatement")]
    public IEnumerable<RemoteFieldApi>? IncomeStatement { get; init; }

    [JsonPropertyName("CreditNote")]
    public IEnumerable<RemoteFieldApi>? CreditNote { get; init; }

    [JsonPropertyName("Item")]
    public IEnumerable<RemoteFieldApi>? Item { get; init; }

    [JsonPropertyName("PurchaseOrder")]
    public IEnumerable<RemoteFieldApi>? PurchaseOrder { get; init; }

    [JsonPropertyName("TrackingCategory")]
    public IEnumerable<RemoteFieldApi>? TrackingCategory { get; init; }

    [JsonPropertyName("JournalEntry")]
    public IEnumerable<RemoteFieldApi>? JournalEntry { get; init; }

    [JsonPropertyName("TaxRate")]
    public IEnumerable<RemoteFieldApi>? TaxRate { get; init; }

    [JsonPropertyName("Invoice")]
    public IEnumerable<RemoteFieldApi>? Invoice { get; init; }

    [JsonPropertyName("Payment")]
    public IEnumerable<RemoteFieldApi>? Payment { get; init; }

    [JsonPropertyName("Expense")]
    public IEnumerable<RemoteFieldApi>? Expense { get; init; }

    [JsonPropertyName("VendorCredit")]
    public IEnumerable<RemoteFieldApi>? VendorCredit { get; init; }

    [JsonPropertyName("Transaction")]
    public IEnumerable<RemoteFieldApi>? Transaction { get; init; }

    [JsonPropertyName("GeneralLedgerTransaction")]
    public IEnumerable<RemoteFieldApi>? GeneralLedgerTransaction { get; init; }
}
