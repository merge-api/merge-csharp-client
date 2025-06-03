using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting;

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

    [JsonPropertyName("PaymentMethod")]
    public IEnumerable<RemoteFieldApi>? PaymentMethod { get; set; }

    [JsonPropertyName("PaymentTerm")]
    public IEnumerable<RemoteFieldApi>? PaymentTerm { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
