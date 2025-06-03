using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public record AccountDetails
{
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("integration")]
    public string? Integration { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("integration_slug")]
    public string? IntegrationSlug { get; set; }

    [JsonPropertyName("category")]
    public CategoryEnum? Category { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("end_user_origin_id")]
    public string? EndUserOriginId { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("end_user_organization_name")]
    public string? EndUserOrganizationName { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("end_user_email_address")]
    public string? EndUserEmailAddress { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("webhook_listener_url")]
    public string? WebhookListenerUrl { get; set; }

    /// <summary>
    /// Whether a Production Linked Account's credentials match another existing Production Linked Account. This field is `null` for Test Linked Accounts, incomplete Production Linked Accounts, and ignored duplicate Production Linked Account sets.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("is_duplicate")]
    public bool? IsDuplicate { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("account_type")]
    public string? AccountType { get; set; }

    /// <summary>
    /// The time at which account completes the linking flow.
    /// </summary>
    [JsonPropertyName("completed_at")]
    public DateTime? CompletedAt { get; set; }

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
