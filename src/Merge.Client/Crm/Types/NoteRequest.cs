using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Crm;

/// <summary>
/// # The Note Object
/// ### Description
/// The `Note` object is used to represent a note on another object.
/// ### Usage Example
/// TODO
/// </summary>
[Serializable]
public record NoteRequest
{
    /// <summary>
    /// The note's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public OneOf<string, User>? Owner { get; set; }

    /// <summary>
    /// The note's content.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// The note's contact.
    /// </summary>
    [JsonPropertyName("contact")]
    public OneOf<string, Contact>? Contact { get; set; }

    /// <summary>
    /// The note's account.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; set; }

    /// <summary>
    /// The note's opportunity.
    /// </summary>
    [JsonPropertyName("opportunity")]
    public OneOf<string, Opportunity>? Opportunity { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

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
