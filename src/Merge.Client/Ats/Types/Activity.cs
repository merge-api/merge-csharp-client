using System.Text.Json.Serialization;
using Merge.Client.Ats;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public class Activity
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The user that performed the action.
    /// </summary>
    [JsonPropertyName("user")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, RemoteUser>>))]
    public OneOf<string, RemoteUser>? User { get; init; }

    /// <summary>
    /// When the third party's activity was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

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

    [JsonPropertyName("candidate")]
    public string? Candidate { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; init; }
}
