using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public record Role
{
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
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The name of the Role.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The set of actions that a User with this Role can perform. Possible enum values include: `VIEW`, `CREATE`, `EDIT`, `DELETE`, `CLOSE`, and `ASSIGN`.
    /// </summary>
    [JsonPropertyName("ticket_actions")]
    public IEnumerable<TicketActionsEnum>? TicketActions { get; set; }

    /// <summary>
    /// The level of Ticket access that a User with this Role can perform.
    ///
    /// - `ALL` - ALL
    /// - `ASSIGNED_ONLY` - ASSIGNED_ONLY
    /// - `TEAM_ONLY` - TEAM_ONLY
    /// </summary>
    [JsonPropertyName("ticket_access")]
    public TicketAccessEnum? TicketAccess { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }
}
