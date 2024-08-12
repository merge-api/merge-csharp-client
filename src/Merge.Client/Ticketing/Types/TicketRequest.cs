using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ticketing;

public record TicketRequest
{
    /// <summary>
    /// The ticket's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("assignees")]
    [JsonConverter(
        typeof(CollectionItemSerializer<OneOf<string, User>, OneOfSerializer<OneOf<string, User>>>)
    )]
    public IEnumerable<OneOf<string, User>>? Assignees { get; set; }

    /// <summary>
    /// The user who created this ticket.
    /// </summary>
    [JsonPropertyName("creator")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, User>>))]
    public OneOf<string, User>? Creator { get; set; }

    /// <summary>
    /// The ticket's due date.
    /// </summary>
    [JsonPropertyName("due_date")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// The current status of the ticket.
    ///
    /// - `OPEN` - OPEN
    /// - `CLOSED` - CLOSED
    /// - `IN_PROGRESS` - IN_PROGRESS
    /// - `ON_HOLD` - ON_HOLD
    /// </summary>
    [JsonPropertyName("status")]
    public TicketStatusEnum? Status { get; set; }

    /// <summary>
    /// The ticket’s description. HTML version of description is mapped if supported by the third-party platform.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("collections")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, Collection>,
            OneOfSerializer<OneOf<string, Collection>>
        >)
    )]
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
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Account>>))]
    public OneOf<string, Account>? Account { get; set; }

    /// <summary>
    /// The contact associated with the ticket.
    /// </summary>
    [JsonPropertyName("contact")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Contact>>))]
    public OneOf<string, Contact>? Contact { get; set; }

    /// <summary>
    /// The ticket's parent ticket.
    /// </summary>
    [JsonPropertyName("parent_ticket")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Ticket>>))]
    public OneOf<string, Ticket>? ParentTicket { get; set; }

    [JsonPropertyName("attachments")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, Attachment>,
            OneOfSerializer<OneOf<string, Attachment>>
        >)
    )]
    public IEnumerable<OneOf<string, Attachment>>? Attachments { get; set; }

    [JsonPropertyName("tags")]
    public IEnumerable<string>? Tags { get; set; }

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
    /// - `URGENT` - URGENT
    /// - `HIGH` - HIGH
    /// - `NORMAL` - NORMAL
    /// - `LOW` - LOW
    /// </summary>
    [JsonPropertyName("priority")]
    public PriorityEnum? Priority { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteFieldRequest>? RemoteFields { get; set; }
}
