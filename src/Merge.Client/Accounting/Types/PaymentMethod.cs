using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

/// <summary>
/// # The PaymentMethod Object
/// ### Description
/// The `PaymentMethod` object defines how a payment against an invoice is made.
///
/// ### Usage Example
/// Fetch from the `GET PaymentMethod` endpoint and view payment method information.
/// </summary>
public record PaymentMethod
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
    /// The type of the payment method.
    ///
    /// * `CREDIT_CARD` - CREDIT_CARD
    /// * `DEBIT_CARD` - DEBIT_CARD
    /// * `ACH` - ACH
    /// * `CASH` - CASH
    /// * `CHECK` - CHECK
    /// </summary>
    [JsonPropertyName("method_type")]
    public required OneOf<MethodTypeEnum, string> MethodType { get; set; }

    /// <summary>
    /// The payment method’s name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// `True` if the payment method is active, `False` if not.
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// When the third party's payment method was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; set; }

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
