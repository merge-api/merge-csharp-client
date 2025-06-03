using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ats;

/// <summary>
/// # The Activity Object
/// ### Description
/// The `Activity` object is used to represent an activity for a candidate performed by a user.
/// ### Usage Example
/// Fetch from the `LIST Activities` endpoint and filter by `ID` to show all activities.
/// </summary>
public record ActivityRequest
{
    /// <summary>
    /// The user that performed the action.
    /// </summary>
    [JsonPropertyName("user")]
    public OneOf<string, RemoteUser>? User { get; set; }

    /// <summary>
    /// The activity's type.
    ///
    /// * `NOTE` - NOTE
    /// * `EMAIL` - EMAIL
    /// * `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("activity_type")]
    public ActivityTypeEnum? ActivityType { get; set; }

    /// <summary>
    /// The activity's subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>
    /// The activity's body.
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// The activity's visibility.
    ///
    /// * `ADMIN_ONLY` - ADMIN_ONLY
    /// * `PUBLIC` - PUBLIC
    /// * `PRIVATE` - PRIVATE
    /// </summary>
    [JsonPropertyName("visibility")]
    public VisibilityEnum? Visibility { get; set; }

    [JsonPropertyName("candidate")]
    public string? Candidate { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

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
