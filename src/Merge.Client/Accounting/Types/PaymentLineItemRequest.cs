using System.Text.Json.Serialization;

namespace Merge.Client.Accounting;

public class PaymentLineItemRequest
{
    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The amount being applied to the transaction.
    /// </summary>
    [JsonPropertyName("applied_amount")]
    public string? AppliedAmount { get; init; }

    /// <summary>
    /// The date the payment portion is applied.
    /// </summary>
    [JsonPropertyName("applied_date")]
    public DateTime? AppliedDate { get; init; }

    /// <summary>
    /// The Merge ID of the transaction the payment portion is being applied to.
    /// </summary>
    [JsonPropertyName("related_object_id")]
    public string? RelatedObjectId { get; init; }

    /// <summary>
    /// The type of transaction the payment portion is being applied to. Possible values include: INVOICE, JOURNAL_ENTRY, or CREDIT_NOTE.
    /// </summary>
    [JsonPropertyName("related_object_type")]
    public string? RelatedObjectType { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
