using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

/// <summary>
/// # The PaymentTerm Object
/// ### Description
/// The `PaymentTerm` object is the agreed-upon conditions between a buyer and a seller that define the timing,
/// amount, and conditions under which payment for goods or services must be made.
///
/// ### Usage Example
/// Fetch from the `GET PaymentTerm` endpoint and view payment term information.
/// </summary>
[Serializable]
public record PaymentTerm
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
    /// The name of the payment term.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// `True` if the payment term is active, `False` if not.
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// The subsidiary that the payment term belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public OneOf<string, CompanyInfo>? Company { get; set; }

    /// <summary>
    /// The number of days after the invoice date that payment is due.
    /// </summary>
    [JsonPropertyName("days_until_due")]
    public int? DaysUntilDue { get; set; }

    /// <summary>
    /// The number of days the invoice must be paid before discounts expire.
    /// </summary>
    [JsonPropertyName("discount_days")]
    public int? DiscountDays { get; set; }

    /// <summary>
    /// When the third party's payment term was modified.
    /// </summary>
    [JsonPropertyName("remote_last_modified_at")]
    public DateTime? RemoteLastModifiedAt { get; set; }

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
