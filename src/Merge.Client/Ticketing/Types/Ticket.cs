using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Ticketing;
using StringEnum;

namespace Merge.Client.Ticketing;

public class Ticket
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The ticket's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("assignees")]
    public List<OneOf<string, User>?>? Assignees { get; init; }

    /// <summary>
    /// The user who created this ticket.
    /// </summary>
    [JsonPropertyName("creator")]
    public OneOf<string, User>? Creator { get; init; }

    /// <summary>
    /// The ticket's due date.
    /// </summary>
    [JsonPropertyName("due_date")]
    public DateTime? DueDate { get; init; }

    /// <summary>
    /// The current status of the ticket.
    /// 
    /// - `OPEN` - OPEN
    /// - `CLOSED` - CLOSED
    /// - `IN_PROGRESS` - IN_PROGRESS
    /// - `ON_HOLD` - ON_HOLD
    /// </summary>
    [JsonPropertyName("status")]
    public StringEnum<TicketStatusEnum>? Status { get; init; }

    /// <summary>
    /// The ticket’s description. HTML version of description is mapped if supported by the third-party platform.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("collections")]
    public List<OneOf<string, Collection>?>? Collections { get; init; }

    /// <summary>
    /// The ticket's type.
    /// </summary>
    [JsonPropertyName("ticket_type")]
    public string? TicketType { get; init; }

    /// <summary>
    /// The account associated with the ticket.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; init; }

    /// <summary>
    /// The contact associated with the ticket.
    /// </summary>
    [JsonPropertyName("contact")]
    public OneOf<string, Contact>? Contact { get; init; }

    /// <summary>
    /// The ticket's parent ticket.
    /// </summary>
    [JsonPropertyName("parent_ticket")]
    public OneOf<string, Ticket>? ParentTicket { get; init; }

    [JsonPropertyName("attachments")]
    public List<OneOf<string, Attachment>?>? Attachments { get; init; }

    [JsonPropertyName("tags")]
    public List<string?>? Tags { get; init; }

    /// <summary>
    /// When the third party's ticket was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    /// <summary>
    /// When the third party's ticket was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; init; }

    /// <summary>
    /// When the ticket was completed.
    /// </summary>
    [JsonPropertyName("completed_at")]
    public DateTime? CompletedAt { get; init; }

    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    /// <summary>
    /// The 3rd party url of the Ticket.
    /// </summary>
    [JsonPropertyName("ticket_url")]
    public string? TicketUrl { get; init; }

    /// <summary>
    /// The priority or urgency of the Ticket.
    /// 
    /// - `URGENT` - URGENT
    /// - `HIGH` - HIGH
    /// - `NORMAL` - NORMAL
    /// - `LOW` - LOW
    /// </summary>
    [JsonPropertyName("priority")]
    public StringEnum<PriorityEnum>? Priority { get; init; }

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

    [JsonPropertyName("remote_fields")]
    public List<RemoteField>? RemoteFields { get; init; }
}
