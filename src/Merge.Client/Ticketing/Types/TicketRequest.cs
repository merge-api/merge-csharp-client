using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class TicketRequest
{
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
    public TicketStatusEnum? Status { get; init; }

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
    /// When the ticket was completed.
    /// </summary>
    [JsonPropertyName("completed_at")]
    public DateTime? CompletedAt { get; init; }

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
    public PriorityEnum? Priority { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }

    [JsonPropertyName("remote_fields")]
    public List<RemoteFieldRequest>? RemoteFields { get; init; }
}
