using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Crm;
using StringEnum;

namespace Merge.Client.Crm;

public class Task
{
    /// <summary>
    /// The task's subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; init; }

    /// <summary>
    /// The task's content.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; init; }

    /// <summary>
    /// The task's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public OneOf<string, User>? Owner { get; init; }

    /// <summary>
    /// The task's account.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; init; }

    /// <summary>
    /// The task's opportunity.
    /// </summary>
    [JsonPropertyName("opportunity")]
    public OneOf<string, Opportunity>? Opportunity { get; init; }

    /// <summary>
    /// When the task is completed.
    /// </summary>
    [JsonPropertyName("completed_date")]
    public DateTime? CompletedDate { get; init; }

    /// <summary>
    /// When the task is due.
    /// </summary>
    [JsonPropertyName("due_date")]
    public DateTime? DueDate { get; init; }

    /// <summary>
    /// The task's status.
    /// 
    /// - `OPEN` - OPEN
    /// - `CLOSED` - CLOSED
    /// </summary>
    [JsonPropertyName("status")]
    public StringEnum<TaskStatusEnum>? Status { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

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
