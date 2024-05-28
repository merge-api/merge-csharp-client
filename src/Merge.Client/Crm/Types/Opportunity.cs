using System.Text.Json.Serialization;
using Merge.Client.Crm;
using OneOf;

#nullable enable

namespace Merge.Client.Crm;

public class Opportunity
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The opportunity's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The opportunity's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The opportunity's amount.
    /// </summary>
    [JsonPropertyName("amount")]
    public int? Amount { get; init; }

    /// <summary>
    /// The opportunity's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public OneOf<string, User>? Owner { get; init; }

    /// <summary>
    /// The account of the opportunity.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; init; }

    /// <summary>
    /// The stage of the opportunity.
    /// </summary>
    [JsonPropertyName("stage")]
    public OneOf<string, Stage>? Stage { get; init; }

    /// <summary>
    /// The opportunity's status.
    ///
    /// - `OPEN` - OPEN
    /// - `WON` - WON
    /// - `LOST` - LOST
    /// </summary>
    [JsonPropertyName("status")]
    public OpportunityStatusEnum? Status { get; init; }

    /// <summary>
    /// When the opportunity's last activity occurred.
    /// </summary>
    [JsonPropertyName("last_activity_at")]
    public DateTime? LastActivityAt { get; init; }

    /// <summary>
    /// When the opportunity was closed.
    /// </summary>
    [JsonPropertyName("close_date")]
    public DateTime? CloseDate { get; init; }

    /// <summary>
    /// When the third party's opportunity was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }

    [JsonPropertyName("remote_fields")]
    public List<RemoteField>? RemoteFields { get; init; }
}
