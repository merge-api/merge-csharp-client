using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Crm;

/// <summary>
/// # The Opportunity Object
/// ### Description
/// The `Opportunity` object is used to represent a deal opportunity in a CRM system.
/// ### Usage Example
/// TODO
/// </summary>
[Serializable]
public record OpportunityRequest
{
    /// <summary>
    /// The opportunity's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The opportunity's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The opportunity's amount.
    /// </summary>
    [JsonPropertyName("amount")]
    public int? Amount { get; set; }

    /// <summary>
    /// The opportunity's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public OneOf<string, User>? Owner { get; set; }

    /// <summary>
    /// The account of the opportunity.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; set; }

    /// <summary>
    /// The stage of the opportunity.
    /// </summary>
    [JsonPropertyName("stage")]
    public OneOf<string, Stage>? Stage { get; set; }

    /// <summary>
    /// The opportunity's status.
    ///
    /// * `OPEN` - OPEN
    /// * `WON` - WON
    /// * `LOST` - LOST
    /// </summary>
    [JsonPropertyName("status")]
    public OneOf<OpportunityStatusEnum, string>? Status { get; set; }

    /// <summary>
    /// When the opportunity's last activity occurred.
    /// </summary>
    [JsonPropertyName("last_activity_at")]
    public DateTime? LastActivityAt { get; set; }

    /// <summary>
    /// When the opportunity was closed.
    /// </summary>
    [JsonPropertyName("close_date")]
    public DateTime? CloseDate { get; set; }

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
