using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record PatchedOpportunityRequest
{
    /// <summary>
    /// The opportunity's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The opportunity's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The opportunity's amount.
    /// </summary>
    [JsonPropertyName("amount")]
    public int? Amount { get; set; }

    /// <summary>
    /// The opportunity's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>
    /// The account of the opportunity.
    /// </summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>
    /// The stage of the opportunity.
    /// </summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }

    /// <summary>
    /// The opportunity's status.
    ///
    /// - `OPEN` - OPEN
    /// - `WON` - WON
    /// - `LOST` - LOST
    /// </summary>
    [JsonPropertyName("status")]
    public OpportunityStatusEnum? Status { get; set; }

    /// <summary>
    /// When the opportunity's last activity occurred.
    /// </summary>
    [JsonPropertyName("last_activity_at")]
    public DateTime? LastActivityAt { get; set; }

    /// <summary>
    /// When the opportunity was closed.
    /// </summary>
    [JsonPropertyName("close_date")]
    public DateTime? CloseDate { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteFieldRequest>? RemoteFields { get; set; }
}
