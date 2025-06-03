using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.FileStorage;

/// <summary>
/// # The LinkedAccount Object
/// ### Description
/// The `LinkedAccount` object is used to represent an end user's link with a specific integration.
///
/// ### Usage Example
/// View a list of your organization's `LinkedAccount` objects.
/// </summary>
public record AccountDetailsAndActions
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("category")]
    public CategoryEnum? Category { get; set; }

    [JsonPropertyName("status")]
    public required AccountDetailsAndActionsStatusEnum Status { get; set; }

    [JsonPropertyName("status_detail")]
    public string? StatusDetail { get; set; }

    [JsonPropertyName("end_user_origin_id")]
    public string? EndUserOriginId { get; set; }

    [JsonPropertyName("end_user_organization_name")]
    public required string EndUserOrganizationName { get; set; }

    [JsonPropertyName("end_user_email_address")]
    public required string EndUserEmailAddress { get; set; }

    /// <summary>
    /// The tenant or domain the customer has provided access to.
    /// </summary>
    [JsonPropertyName("subdomain")]
    public string? Subdomain { get; set; }

    [JsonPropertyName("webhook_listener_url")]
    public required string WebhookListenerUrl { get; set; }

    /// <summary>
    /// Whether a Production Linked Account's credentials match another existing Production Linked Account. This field is `null` for Test Linked Accounts, incomplete Production Linked Accounts, and ignored duplicate Production Linked Account sets.
    /// </summary>
    [JsonPropertyName("is_duplicate")]
    public bool? IsDuplicate { get; set; }

    [JsonPropertyName("integration")]
    public AccountDetailsAndActionsIntegration? Integration { get; set; }

    [JsonPropertyName("account_type")]
    public required string AccountType { get; set; }

    [JsonPropertyName("completed_at")]
    public required DateTime CompletedAt { get; set; }

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
