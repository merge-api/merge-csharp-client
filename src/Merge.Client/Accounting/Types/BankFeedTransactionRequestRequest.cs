using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

public record BankFeedTransactionRequestRequest
{
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
    /// - `CREDIT` - CREDIT
    /// - `DEBIT` - DEBIT
    /// </summary>
    [JsonPropertyName("credit_or_debit")]
    public CreditOrDebitEnum? CreditOrDebit { get; set; }

    /// <summary>
    /// The customer’s identifier for the transaction.
    /// </summary>
    [JsonPropertyName("source_transaction_id")]
    public string? SourceTransactionId { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
