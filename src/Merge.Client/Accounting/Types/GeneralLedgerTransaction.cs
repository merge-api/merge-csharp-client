using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

public record GeneralLedgerTransaction
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The third party remote ID of the underlying transaction.
    /// </summary>
    [JsonPropertyName("underlying_transaction_remote_id")]
    public string? UnderlyingTransactionRemoteId { get; set; }

    /// <summary>
    /// The type of the underlying transaction.
    ///
    /// - `INVOICE` - INVOICE
    /// - `EXPENSE` - EXPENSE
    /// - `TRANSACTION` - TRANSACTION
    /// - `JOURNAL_ENTRY` - JOURNAL_ENTRY
    /// - `PAYMENT` - PAYMENT
    /// - `VENDOR_CREDIT` - VENDOR_CREDIT
    /// - `CREDIT_NOTE` - CREDIT_NOTE
    /// </summary>
    [JsonPropertyName("underlying_transaction_type")]
    public UnderlyingTransactionTypeEnum? UnderlyingTransactionType { get; set; }

    /// <summary>
    /// The accounting period that the GeneralLedgerTransaction was generated in.
    /// </summary>
    [JsonPropertyName("accounting_period")]
    public OneOf<string, AccountingPeriod>? AccountingPeriod { get; set; }

    /// <summary>
    /// The company the GeneralLedgerTransaction belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public OneOf<string, CompanyInfo>? Company { get; set; }

    /// <summary>
    /// When the third party's GeneralLedgerTransaction entry was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; set; }

    /// <summary>
    /// When the third party's GeneralLedgerTransaction entry was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    [JsonPropertyName("tracking_categories")]
    public IEnumerable<OneOf<string, TrackingCategory>>? TrackingCategories { get; set; }

    /// <summary>
    /// The date that the transaction was posted to the general ledger.
    /// </summary>
    [JsonPropertyName("posting_date")]
    public DateTime? PostingDate { get; set; }

    /// <summary>
    /// A list of “General Ledger Transaction Applied to Lines” objects.
    /// </summary>
    [JsonPropertyName("general_ledger_transaction_lines")]
    public IEnumerable<
        OneOf<string, GeneralLedgerTransactionLine>
    >? GeneralLedgerTransactionLines { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
