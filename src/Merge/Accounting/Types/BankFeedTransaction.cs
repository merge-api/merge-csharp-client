using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;
using OneOf;

namespace Merge.Accounting;

/// <summary>
/// # The BankFeedTransaction Object
/// ### Description
/// The `BankFeedTransaction` object is used to represent transactions linked to a bank feed account. This includes details about the transaction such as the date, amount, description, and type.
///
/// ### Usage Example
/// Fetch from the `GET BankFeedTransaction` endpoint to view details of a transaction associated with a bank feed account.
/// </summary>
public record BankFeedTransaction
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
    /// The bank feed account associated with the transaction.
    /// </summary>
    [JsonPropertyName("bank_feed_account")]
    public OneOf<string, BankFeedAccount>? BankFeedAccount { get; set; }

    /// <summary>
    /// The date that the transaction occurred.
    /// </summary>
    [JsonPropertyName("transaction_date")]
    public DateTime? TransactionDate { get; set; }

    /// <summary>
    /// The date the transaction was posted to the bank account.
    /// </summary>
    [JsonPropertyName("posted_date")]
    public DateTime? PostedDate { get; set; }

    /// <summary>
    /// The amount of the transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>
    /// The description of the transaction.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The underlying type of the transaction.
    /// </summary>
    [JsonPropertyName("transaction_type")]
    public string? TransactionType { get; set; }

    /// <summary>
    /// The person or merchant who initiated the transaction, or alternatively, to whom the transaction was paid.
    /// </summary>
    [JsonPropertyName("payee")]
    public string? Payee { get; set; }

    /// <summary>
    /// If the transaction is of type debit or credit.
    ///
    /// * `CREDIT` - CREDIT
    /// * `DEBIT` - DEBIT
    /// </summary>
    [JsonPropertyName("credit_or_debit")]
    public CreditOrDebitEnum? CreditOrDebit { get; set; }

    /// <summary>
    /// The customer’s identifier for the transaction.
    /// </summary>
    [JsonPropertyName("source_transaction_id")]
    public string? SourceTransactionId { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    /// <summary>
    /// Whether or not this transaction has been processed by the external system. For example, NetSuite writes this field as True when the SuiteApp has processed the transaction.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("is_processed")]
    public bool? IsProcessed { get; set; }

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
