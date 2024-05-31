using System.Text.Json.Serialization;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<FieldMappingApiInstance>? Account { get; init; }

    [JsonPropertyName("AccountingAttachment")]
    public IEnumerable<FieldMappingApiInstance>? AccountingAttachment { get; init; }

    [JsonPropertyName("BalanceSheet")]
    public IEnumerable<FieldMappingApiInstance>? BalanceSheet { get; init; }

    [JsonPropertyName("CashFlowStatement")]
    public IEnumerable<FieldMappingApiInstance>? CashFlowStatement { get; init; }

    [JsonPropertyName("CompanyInfo")]
    public IEnumerable<FieldMappingApiInstance>? CompanyInfo { get; init; }

    [JsonPropertyName("Contact")]
    public IEnumerable<FieldMappingApiInstance>? Contact { get; init; }

    [JsonPropertyName("IncomeStatement")]
    public IEnumerable<FieldMappingApiInstance>? IncomeStatement { get; init; }

    [JsonPropertyName("CreditNote")]
    public IEnumerable<FieldMappingApiInstance>? CreditNote { get; init; }

    [JsonPropertyName("Item")]
    public IEnumerable<FieldMappingApiInstance>? Item { get; init; }

    [JsonPropertyName("PurchaseOrder")]
    public IEnumerable<FieldMappingApiInstance>? PurchaseOrder { get; init; }

    [JsonPropertyName("TrackingCategory")]
    public IEnumerable<FieldMappingApiInstance>? TrackingCategory { get; init; }

    [JsonPropertyName("JournalEntry")]
    public IEnumerable<FieldMappingApiInstance>? JournalEntry { get; init; }

    [JsonPropertyName("TaxRate")]
    public IEnumerable<FieldMappingApiInstance>? TaxRate { get; init; }

    [JsonPropertyName("Invoice")]
    public IEnumerable<FieldMappingApiInstance>? Invoice { get; init; }

    [JsonPropertyName("Payment")]
    public IEnumerable<FieldMappingApiInstance>? Payment { get; init; }

    [JsonPropertyName("Expense")]
    public IEnumerable<FieldMappingApiInstance>? Expense { get; init; }

    [JsonPropertyName("VendorCredit")]
    public IEnumerable<FieldMappingApiInstance>? VendorCredit { get; init; }

    [JsonPropertyName("Transaction")]
    public IEnumerable<FieldMappingApiInstance>? Transaction { get; init; }

    [JsonPropertyName("GeneralLedgerTransaction")]
    public IEnumerable<FieldMappingApiInstance>? GeneralLedgerTransaction { get; init; }
}
