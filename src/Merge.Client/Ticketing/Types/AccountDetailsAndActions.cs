using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class AccountDetailsAndActions
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("category")]
    public CategoryEnum? Category { get; init; }

    [JsonPropertyName("status")]
    public AccountDetailsAndActionsStatusEnum Status { get; init; }

    [JsonPropertyName("status_detail")]
    public string? StatusDetail { get; init; }

    [JsonPropertyName("end_user_origin_id")]
    public string? EndUserOriginId { get; init; }

    [JsonPropertyName("end_user_organization_name")]
    public string EndUserOrganizationName { get; init; }

    [JsonPropertyName("end_user_email_address")]
    public string EndUserEmailAddress { get; init; }

    /// <summary>
    /// The tenant or domain the customer has provided access to.
    /// </summary>
    [JsonPropertyName("subdomain")]
    public string? Subdomain { get; init; }

    [JsonPropertyName("webhook_listener_url")]
    public string WebhookListenerUrl { get; init; }

    /// <summary>
    /// Whether a Production Linked Account's credentials match another existing Production Linked Account. This field is `null` for Test Linked Accounts, incomplete Production Linked Accounts, and ignored duplicate Production Linked Account sets.
    /// </summary>
    [JsonPropertyName("is_duplicate")]
    public bool? IsDuplicate { get; init; }

    [JsonPropertyName("integration")]
    public AccountDetailsAndActionsIntegration? Integration { get; init; }

    [JsonPropertyName("account_type")]
    public string AccountType { get; init; }
}
