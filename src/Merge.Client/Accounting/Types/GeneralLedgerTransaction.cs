using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

/// <summary>
/// # The GeneralLedgerTransaction Object
/// ### Description
/// A General Ledger Entry is a record of a financial transaction that is posted to the general ledger, the central repository of a company’s financial data.
///
/// The `GeneralLedgerTransaction` object is a singular endpoint to pull all transactions posted to a company’s general ledger. The transaction that generated the `GeneralLedgerTransaction` can be found by referencing the `underlying_transaction_type` and `underlying_transaction_remote_id` fields.
///
/// The lines of a `GeneralLedgerTransaction` object will always have equal amounts of debits and credits.
///
/// ### Usage Example
/// Fetch from the `GET GeneralLedgerTransaction` endpoint and view a general ledger transaction.
/// </summary>
public record GeneralLedgerTransaction
{
    [JsonAccess(JsonAccessType.ReadOnly)]
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
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
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
    /// * `INVOICE` - INVOICE
    /// * `EXPENSE` - EXPENSE
    /// * `TRANSACTION` - TRANSACTION
    /// * `JOURNAL_ENTRY` - JOURNAL_ENTRY
    /// * `PAYMENT` - PAYMENT
    /// * `VENDOR_CREDIT` - VENDOR_CREDIT
    /// * `CREDIT_NOTE` - CREDIT_NOTE
    /// </summary>
    [JsonPropertyName("underlying_transaction_type")]
    public OneOf<UnderlyingTransactionTypeEnum, string>? UnderlyingTransactionType { get; set; }

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
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("general_ledger_transaction_lines")]
    public IEnumerable<
        OneOf<string, GeneralLedgerTransactionLine>
    >? GeneralLedgerTransactionLines { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

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
