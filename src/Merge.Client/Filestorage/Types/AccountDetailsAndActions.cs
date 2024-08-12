using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

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
}
