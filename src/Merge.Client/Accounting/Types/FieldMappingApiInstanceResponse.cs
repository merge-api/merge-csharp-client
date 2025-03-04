using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public record FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<FieldMappingApiInstance>? Account { get; set; }

    [JsonPropertyName("AccountingAttachment")]
    public IEnumerable<FieldMappingApiInstance>? AccountingAttachment { get; set; }

    [JsonPropertyName("BalanceSheet")]
    public IEnumerable<FieldMappingApiInstance>? BalanceSheet { get; set; }

    [JsonPropertyName("CashFlowStatement")]
    public IEnumerable<FieldMappingApiInstance>? CashFlowStatement { get; set; }

    [JsonPropertyName("CompanyInfo")]
    public IEnumerable<FieldMappingApiInstance>? CompanyInfo { get; set; }

    [JsonPropertyName("Contact")]
    public IEnumerable<FieldMappingApiInstance>? Contact { get; set; }

    [JsonPropertyName("IncomeStatement")]
    public IEnumerable<FieldMappingApiInstance>? IncomeStatement { get; set; }

    [JsonPropertyName("CreditNote")]
    public IEnumerable<FieldMappingApiInstance>? CreditNote { get; set; }

    [JsonPropertyName("Item")]
    public IEnumerable<FieldMappingApiInstance>? Item { get; set; }

    [JsonPropertyName("PurchaseOrder")]
    public IEnumerable<FieldMappingApiInstance>? PurchaseOrder { get; set; }

    [JsonPropertyName("TrackingCategory")]
    public IEnumerable<FieldMappingApiInstance>? TrackingCategory { get; set; }

    [JsonPropertyName("JournalEntry")]
    public IEnumerable<FieldMappingApiInstance>? JournalEntry { get; set; }

    [JsonPropertyName("TaxRate")]
    public IEnumerable<FieldMappingApiInstance>? TaxRate { get; set; }

    [JsonPropertyName("Invoice")]
    public IEnumerable<FieldMappingApiInstance>? Invoice { get; set; }

    [JsonPropertyName("Payment")]
    public IEnumerable<FieldMappingApiInstance>? Payment { get; set; }

    [JsonPropertyName("Expense")]
    public IEnumerable<FieldMappingApiInstance>? Expense { get; set; }

    [JsonPropertyName("VendorCredit")]
    public IEnumerable<FieldMappingApiInstance>? VendorCredit { get; set; }

    [JsonPropertyName("Transaction")]
    public IEnumerable<FieldMappingApiInstance>? Transaction { get; set; }

    [JsonPropertyName("AccountingPeriod")]
    public IEnumerable<FieldMappingApiInstance>? AccountingPeriod { get; set; }

    [JsonPropertyName("GeneralLedgerTransaction")]
    public IEnumerable<FieldMappingApiInstance>? GeneralLedgerTransaction { get; set; }

    [JsonPropertyName("BankFeedAccount")]
    public IEnumerable<FieldMappingApiInstance>? BankFeedAccount { get; set; }

    [JsonPropertyName("Employee")]
    public IEnumerable<FieldMappingApiInstance>? Employee { get; set; }

    [JsonPropertyName("PaymentMethod")]
    public IEnumerable<FieldMappingApiInstance>? PaymentMethod { get; set; }

    [JsonPropertyName("PaymentTerm")]
    public IEnumerable<FieldMappingApiInstance>? PaymentTerm { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
