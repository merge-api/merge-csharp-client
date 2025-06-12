using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Crm;

/// <summary>
/// # The Engagement Object
/// ### Description
/// The `Engagement` object is used to represent an interaction noted in a CRM system.
/// ### Usage Example
/// TODO
/// </summary>
public record EngagementRequest
{
    /// <summary>
    /// The engagement's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public OneOf<string, User>? Owner { get; set; }

    /// <summary>
    /// The engagement's content.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// The engagement's subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>
    /// The engagement's direction.
    ///
    /// * `INBOUND` - INBOUND
    /// * `OUTBOUND` - OUTBOUND
    /// </summary>
    [JsonPropertyName("direction")]
    public OneOf<DirectionEnum, string>? Direction { get; set; }

    /// <summary>
    /// The engagement type of the engagement.
    /// </summary>
    [JsonPropertyName("engagement_type")]
    public OneOf<string, EngagementType>? EngagementType { get; set; }

    /// <summary>
    /// The time at which the engagement started.
    /// </summary>
    [JsonPropertyName("start_time")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The time at which the engagement ended.
    /// </summary>
    [JsonPropertyName("end_time")]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// The account of the engagement.
    /// </summary>
    [JsonPropertyName("account")]
    public OneOf<string, Account>? Account { get; set; }

    [JsonPropertyName("contacts")]
    public IEnumerable<OneOf<string, Contact>>? Contacts { get; set; }

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
