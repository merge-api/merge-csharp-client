using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

/// <summary>
/// # The PaymentLineItem Object
/// ### Description
/// The `PaymentLineItem` object is an applied-to-line on a `Payment` that can either be a `Invoice`, `CreditNote`, or `JournalEntry`.
///
/// ### Usage Example
/// `Payment` will have a field called `applied-to-lines` which will be an array of `PaymentLineItemInternalMappingSerializer` objects that can either be a `Invoice`, `CreditNote`, or `JournalEntry`.
/// </summary>
[Serializable]
public record PaymentLineItem
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
    /// The amount being applied to the transaction.
    /// </summary>
    [JsonPropertyName("applied_amount")]
    public string? AppliedAmount { get; set; }

    /// <summary>
    /// The date the payment portion is applied.
    /// </summary>
    [JsonPropertyName("applied_date")]
    public DateTime? AppliedDate { get; set; }

    /// <summary>
    /// The Merge ID of the transaction the payment portion is being applied to.
    /// </summary>
    [JsonPropertyName("related_object_id")]
    public string? RelatedObjectId { get; set; }

    /// <summary>
    /// The type of transaction the payment portion is being applied to. Possible values include: INVOICE, JOURNAL_ENTRY, or CREDIT_NOTE.
    /// </summary>
    [JsonPropertyName("related_object_type")]
    public string? RelatedObjectType { get; set; }

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
