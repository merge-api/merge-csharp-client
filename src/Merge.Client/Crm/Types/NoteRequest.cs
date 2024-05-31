using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Crm;
using OneOf;

#nullable enable

namespace Merge.Client.Crm;

public class NoteRequest
{
    /// <summary>
    /// The note's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, User>>))]
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
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Contact>>))]
    public OneOf<string, Contact>? Contact { get; init; }

    /// <summary>
    /// The note's account.
    /// </summary>
    [JsonPropertyName("account")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Account>>))]
    public OneOf<string, Account>? Account { get; init; }

    /// <summary>
    /// The note's opportunity.
    /// </summary>
    [JsonPropertyName("opportunity")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Opportunity>>))]
    public OneOf<string, Opportunity>? Opportunity { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }

    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteFieldRequest>? RemoteFields { get; init; }
}
