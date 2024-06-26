using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class EngagementType
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
    /// The engagement type's activity type.
    ///
    /// - `CALL` - CALL
    /// - `MEETING` - MEETING
    /// - `EMAIL` - EMAIL
    /// </summary>
    [JsonPropertyName("activity_type")]
    public ActivityTypeEnum? ActivityType { get; init; }

    /// <summary>
    /// The engagement type's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteField>? RemoteFields { get; init; }
}
