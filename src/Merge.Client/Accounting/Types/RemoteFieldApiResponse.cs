using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

public record RemoteFieldApiResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<RemoteFieldApi>? Account { get; set; }

    [JsonPropertyName("AccountingAttachment")]
    public IEnumerable<RemoteFieldApi>? AccountingAttachment { get; set; }

    [JsonPropertyName("BalanceSheet")]
    public IEnumerable<RemoteFieldApi>? BalanceSheet { get; set; }

    [JsonPropertyName("CashFlowStatement")]
    public IEnumerable<RemoteFieldApi>? CashFlowStatement { get; set; }

    [JsonPropertyName("CompanyInfo")]
    public IEnumerable<RemoteFieldApi>? CompanyInfo { get; set; }

    [JsonPropertyName("Contact")]
    public IEnumerable<RemoteFieldApi>? Contact { get; set; }

    [JsonPropertyName("IncomeStatement")]
    public IEnumerable<RemoteFieldApi>? IncomeStatement { get; set; }

    [JsonPropertyName("CreditNote")]
    public IEnumerable<RemoteFieldApi>? CreditNote { get; set; }

    [JsonPropertyName("Item")]
    public IEnumerable<RemoteFieldApi>? Item { get; set; }

    [JsonPropertyName("PurchaseOrder")]
    public IEnumerable<RemoteFieldApi>? PurchaseOrder { get; set; }

    [JsonPropertyName("TrackingCategory")]
    public IEnumerable<RemoteFieldApi>? TrackingCategory { get; set; }

    [JsonPropertyName("JournalEntry")]
    public IEnumerable<RemoteFieldApi>? JournalEntry { get; set; }

    [JsonPropertyName("TaxRate")]
    public IEnumerable<RemoteFieldApi>? TaxRate { get; set; }

    [JsonPropertyName("Invoice")]
    public IEnumerable<RemoteFieldApi>? Invoice { get; set; }

    [JsonPropertyName("Payment")]
    public IEnumerable<RemoteFieldApi>? Payment { get; set; }

    [JsonPropertyName("Expense")]
    public IEnumerable<RemoteFieldApi>? Expense { get; set; }

    [JsonPropertyName("VendorCredit")]
    public IEnumerable<RemoteFieldApi>? VendorCredit { get; set; }

    [JsonPropertyName("Transaction")]
    public IEnumerable<RemoteFieldApi>? Transaction { get; set; }

    [JsonPropertyName("AccountingPeriod")]
    public IEnumerable<RemoteFieldApi>? AccountingPeriod { get; set; }

    [JsonPropertyName("GeneralLedgerTransaction")]
    public IEnumerable<RemoteFieldApi>? GeneralLedgerTransaction { get; set; }

    [JsonPropertyName("BankFeedAccount")]
    public IEnumerable<RemoteFieldApi>? BankFeedAccount { get; set; }

    [JsonPropertyName("Employee")]
    public IEnumerable<RemoteFieldApi>? Employee { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
