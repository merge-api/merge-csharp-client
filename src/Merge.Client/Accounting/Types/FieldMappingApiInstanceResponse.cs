using System.Text.Json.Serialization;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Account")]
    public List<FieldMappingApiInstance>? Account { get; init; }

    [JsonPropertyName("AccountingAttachment")]
    public List<FieldMappingApiInstance>? AccountingAttachment { get; init; }

    [JsonPropertyName("BalanceSheet")]
    public List<FieldMappingApiInstance>? BalanceSheet { get; init; }

    [JsonPropertyName("CashFlowStatement")]
    public List<FieldMappingApiInstance>? CashFlowStatement { get; init; }

    [JsonPropertyName("CompanyInfo")]
    public List<FieldMappingApiInstance>? CompanyInfo { get; init; }

    [JsonPropertyName("Contact")]
    public List<FieldMappingApiInstance>? Contact { get; init; }

    [JsonPropertyName("IncomeStatement")]
    public List<FieldMappingApiInstance>? IncomeStatement { get; init; }

    [JsonPropertyName("CreditNote")]
    public List<FieldMappingApiInstance>? CreditNote { get; init; }

    [JsonPropertyName("Item")]
    public List<FieldMappingApiInstance>? Item { get; init; }

    [JsonPropertyName("PurchaseOrder")]
    public List<FieldMappingApiInstance>? PurchaseOrder { get; init; }

    [JsonPropertyName("TrackingCategory")]
    public List<FieldMappingApiInstance>? TrackingCategory { get; init; }

    [JsonPropertyName("JournalEntry")]
    public List<FieldMappingApiInstance>? JournalEntry { get; init; }

    [JsonPropertyName("TaxRate")]
    public List<FieldMappingApiInstance>? TaxRate { get; init; }

    [JsonPropertyName("Invoice")]
    public List<FieldMappingApiInstance>? Invoice { get; init; }

    [JsonPropertyName("Payment")]
    public List<FieldMappingApiInstance>? Payment { get; init; }

    [JsonPropertyName("Expense")]
    public List<FieldMappingApiInstance>? Expense { get; init; }

    [JsonPropertyName("VendorCredit")]
    public List<FieldMappingApiInstance>? VendorCredit { get; init; }

    [JsonPropertyName("Transaction")]
    public List<FieldMappingApiInstance>? Transaction { get; init; }

    [JsonPropertyName("GeneralLedgerTransaction")]
    public List<FieldMappingApiInstance>? GeneralLedgerTransaction { get; init; }
}
