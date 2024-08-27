using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

public record PatchedTaskRequest
{
    /// <summary>
    /// The task's subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>
    /// The task's content.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// The task's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>
    /// The task's account.
    /// </summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>
    /// The task's opportunity.
    /// </summary>
    [JsonPropertyName("opportunity")]
    public string? Opportunity { get; set; }

    /// <summary>
    /// When the task is completed.
    /// </summary>
    [JsonPropertyName("completed_date")]
    public DateTime? CompletedDate { get; set; }

    /// <summary>
    /// When the task is due.
    /// </summary>
    [JsonPropertyName("due_date")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// The task's status.
    ///
    /// - `OPEN` - OPEN
    /// - `CLOSED` - CLOSED
    /// </summary>
    [JsonPropertyName("status")]
    public TaskStatusEnum? Status { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteFieldRequest>? RemoteFields { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
