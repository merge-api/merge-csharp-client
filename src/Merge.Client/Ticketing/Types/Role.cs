using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class Role
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The name of the Role.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The set of actions that a User with this Role can perform. Possible enum values include: `VIEW`, `CREATE`, `EDIT`, `DELETE`, `CLOSE`, and `ASSIGN`.
    /// </summary>
    [JsonPropertyName("ticket_actions")]
    public List<TicketActionsEnum>? TicketActions { get; init; }

    /// <summary>
    /// The level of Ticket access that a User with this Role can perform.
    /// 
    /// - `ALL` - ALL
    /// - `ASSIGNED_ONLY` - ASSIGNED_ONLY
    /// - `TEAM_ONLY` - TEAM_ONLY
    /// </summary>
    [JsonPropertyName("ticket_access")]
    public TicketAccessEnum? TicketAccess { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
