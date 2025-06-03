using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing;

/// <summary>
/// # The Ticket Object
/// ### Description
/// The `Ticket` object is used to represent a ticket, issue, task or case.
/// ### Usage Example
/// TODO
/// </summary>
public record PatchedTicketRequest
{
    /// <summary>
    /// The ticket's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The individual `Users` who are assigned to this ticket. This does not include `Users` who just have view access to this ticket. To fetch all `Users` and `Teams` that can access the ticket, use the `GET /tickets/{ticket_id}/viewers` [endpoint](https://docs.merge.dev/ticketing/tickets/#tickets_viewers_list).
    /// </summary>
    [JsonPropertyName("assignees")]
    public IEnumerable<string>? Assignees { get; set; }

    /// <summary>
    /// The `Teams` that are assigned to this ticket. This does not include `Teams` who just have view access to this ticket. To fetch all `Users` and `Teams` that can access this ticket, use the `GET /tickets/{ticket_id}/viewers` [endpoint](https://docs.merge.dev/ticketing/tickets/#tickets_viewers_list).
    /// </summary>
    [JsonPropertyName("assigned_teams")]
    public IEnumerable<string>? AssignedTeams { get; set; }

    /// <summary>
    /// The user who created this ticket.
    /// </summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

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
    public TicketStatusEnum? Status { get; set; }

    /// <summary>
    /// The ticket’s description. HTML version of description is mapped if supported by the third-party platform.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The `Collections` that this `Ticket` is included in.
    /// </summary>
    [JsonPropertyName("collections")]
    public IEnumerable<string>? Collections { get; set; }

    /// <summary>
    /// The sub category of the ticket within the 3rd party system. Examples include incident, task, subtask or to-do.
    /// </summary>
    [JsonPropertyName("ticket_type")]
    public string? TicketType { get; set; }

    /// <summary>
    /// The account associated with the ticket.
    /// </summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>
    /// The contact associated with the ticket.
    /// </summary>
    [JsonPropertyName("contact")]
    public string? Contact { get; set; }

    /// <summary>
    /// The ticket's parent ticket.
    /// </summary>
    [JsonPropertyName("parent_ticket")]
    public string? ParentTicket { get; set; }

    [JsonPropertyName("tags")]
    public IEnumerable<string>? Tags { get; set; }

    [JsonPropertyName("roles")]
    public IEnumerable<string>? Roles { get; set; }

    /// <summary>
    /// When the ticket was completed.
    /// </summary>
    [JsonPropertyName("completed_at")]
    public DateTime? CompletedAt { get; set; }

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
    public PriorityEnum? Priority { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public object? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public object? LinkedAccountParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteFieldRequest>? RemoteFields { get; set; }

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
