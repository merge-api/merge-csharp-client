using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class NoteRequest
{
    /// <summary>
    /// The note's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public OneOf<string, User>? Owner { get; init; }

    /// <summary>
    /// The note's content.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; init; }

    /// <summary>
    /// The note's contact.
    /// </summary>
    [JsonPropertyName("contact")]
    public OneOf<string, Contact>? Contact { get; init; }

    /// <summary>
    /// The note's account.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; init; }

    /// <summary>
    /// The note's opportunity.
    /// </summary>
    [JsonPropertyName("opportunity")]
    public OneOf<string, Opportunity>? Opportunity { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }

    [JsonPropertyName("remote_fields")]
    public List<RemoteFieldRequest>? RemoteFields { get; init; }
}
