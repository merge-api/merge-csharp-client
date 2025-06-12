using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ticketing;

/// <summary>
/// # The Ticket Object
/// ### Description
/// The `Ticket` object is used to represent a ticket, issue, task or case.
/// ### Usage Example
/// TODO
/// </summary>
public record Ticket
{
    [JsonAccess(JsonAccessType.ReadOnly)]
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
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The ticket's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The individual `Users` who are assigned to this ticket. This does not include `Users` who just have view access to this ticket. To fetch all `Users` and `Teams` that can access the ticket, use the `GET /tickets/{ticket_id}/viewers` [endpoint](https://docs.merge.dev/ticketing/tickets/#tickets_viewers_list).
    /// </summary>
    [JsonPropertyName("assignees")]
    public IEnumerable<OneOf<string, User>>? Assignees { get; set; }

    /// <summary>
    /// The `Teams` that are assigned to this ticket. This does not include `Teams` who just have view access to this ticket. To fetch all `Users` and `Teams` that can access this ticket, use the `GET /tickets/{ticket_id}/viewers` [endpoint](https://docs.merge.dev/ticketing/tickets/#tickets_viewers_list).
    /// </summary>
    [JsonPropertyName("assigned_teams")]
    public IEnumerable<OneOf<string, Team>>? AssignedTeams { get; set; }

    /// <summary>
    /// The user who created this ticket.
    /// </summary>
    [JsonPropertyName("creator")]
    public OneOf<string, User>? Creator { get; set; }

    /// <summary>
    /// The ticket's due date.
    /// </summary>
    [JsonPropertyName("due_date")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// The current status of the ticket.
    ///
    /// * `OPEN` - OPEN
    /// * `CLOSED` - CLOSED
    /// * `IN_PROGRESS` - IN_PROGRESS
    /// * `ON_HOLD` - ON_HOLD
    /// </summary>
    [JsonPropertyName("status")]
    public OneOf<TicketStatusEnum, string>? Status { get; set; }

    /// <summary>
    /// The ticket’s description. HTML version of description is mapped if supported by the third-party platform.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The `Collections` that this `Ticket` is included in.
    /// </summary>
    [JsonPropertyName("collections")]
    public IEnumerable<OneOf<string, Collection>>? Collections { get; set; }

    /// <summary>
    /// The sub category of the ticket within the 3rd party system. Examples include incident, task, subtask or to-do.
    /// </summary>
    [JsonPropertyName("ticket_type")]
    public string? TicketType { get; set; }

    /// <summary>
    /// The account associated with the ticket.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; set; }

    /// <summary>
    /// The contact associated with the ticket.
    /// </summary>
    [JsonPropertyName("contact")]
    public OneOf<string, Contact>? Contact { get; set; }

    /// <summary>
    /// The ticket's parent ticket.
    /// </summary>
    [JsonPropertyName("parent_ticket")]
    public OneOf<string, Ticket>? ParentTicket { get; set; }

    [JsonPropertyName("attachments")]
    public IEnumerable<OneOf<string, Attachment>>? Attachments { get; set; }

    /// <summary>
    /// The description of who is able to access a given ticket, or where access is inherited from.
    ///
    /// * `COMPANY` - COMPANY
    /// * `PUBLIC` - PUBLIC
    /// * `PRIVATE` - PRIVATE
    /// * `COLLECTION` - COLLECTION
    /// </summary>
    [JsonPropertyName("access_level")]
    public OneOf<TicketAccessLevelEnum, string>? AccessLevel { get; set; }

    [JsonPropertyName("tags")]
    public IEnumerable<string>? Tags { get; set; }

    [JsonPropertyName("roles")]
    public IEnumerable<string>? Roles { get; set; }

    /// <summary>
    /// The 3rd party url of the Ticket.
    /// </summary>
    [JsonPropertyName("ticket_url")]
    public string? TicketUrl { get; set; }

    /// <summary>
    /// The priority or urgency of the Ticket.
    ///
    /// * `URGENT` - URGENT
    /// * `HIGH` - HIGH
    /// * `NORMAL` - NORMAL
    /// * `LOW` - LOW
    /// </summary>
    [JsonPropertyName("priority")]
    public OneOf<PriorityEnum, string>? Priority { get; set; }

    /// <summary>
    /// When the third party's ticket was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    /// <summary>
    /// When the third party's ticket was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; set; }

    /// <summary>
    /// When the ticket was completed.
    /// </summary>
    [JsonPropertyName("completed_at")]
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteField>? RemoteFields { get; set; }

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
