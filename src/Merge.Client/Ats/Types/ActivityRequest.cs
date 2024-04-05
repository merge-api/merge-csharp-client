using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class ActivityRequest
{
    /// <summary>
    /// The user that performed the action.
    /// </summary>
    [JsonPropertyName("user")]
    public OneOf<string, RemoteUser>? User { get; init; }

    /// <summary>
    /// The activity's type.
    /// 
    /// - `NOTE` - NOTE
    /// - `EMAIL` - EMAIL
    /// - `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("activity_type")]
    public ActivityTypeEnum? ActivityType { get; init; }

    /// <summary>
    /// The activity's subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; init; }

    /// <summary>
    /// The activity's body.
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; init; }

    /// <summary>
    /// The activity's visibility.
    /// 
    /// - `ADMIN_ONLY` - ADMIN_ONLY
    /// - `PUBLIC` - PUBLIC
    /// - `PRIVATE` - PRIVATE
    /// </summary>
    [JsonPropertyName("visibility")]
    public VisibilityEnum? Visibility { get; init; }

    /// <summary>
    /// The activity’s candidate.
    /// </summary>
    [JsonPropertyName("candidate")]
    public string? Candidate { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
