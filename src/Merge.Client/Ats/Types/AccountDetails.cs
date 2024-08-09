using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record AccountDetails
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("integration")]
    public string? Integration { get; set; }

    [JsonPropertyName("integration_slug")]
    public string? IntegrationSlug { get; set; }

    [JsonPropertyName("category")]
    public CategoryEnum? Category { get; set; }

    [JsonPropertyName("end_user_origin_id")]
    public string? EndUserOriginId { get; set; }

    [JsonPropertyName("end_user_organization_name")]
    public string? EndUserOrganizationName { get; set; }

    [JsonPropertyName("end_user_email_address")]
    public string? EndUserEmailAddress { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("webhook_listener_url")]
    public string? WebhookListenerUrl { get; set; }

    /// <summary>
    /// Whether a Production Linked Account's credentials match another existing Production Linked Account. This field is `null` for Test Linked Accounts, incomplete Production Linked Accounts, and ignored duplicate Production Linked Account sets.
    /// </summary>
    [JsonPropertyName("is_duplicate")]
    public bool? IsDuplicate { get; set; }

    [JsonPropertyName("account_type")]
    public string? AccountType { get; set; }
}
