using System.Text.Json.Serialization;
using StringEnum;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class EngagementType
{
    /// <summary>
    /// The engagement type's activity type.
    /// 
    /// - `CALL` - CALL
    /// - `MEETING` - MEETING
    /// - `EMAIL` - EMAIL
    /// </summary>
    [JsonPropertyName("activity_type")]
    public StringEnum<ActivityTypeEnum>? ActivityType { get; init; }

    /// <summary>
    /// The engagement type's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    [JsonPropertyName("remote_fields")]
    public List<RemoteField>? RemoteFields { get; init; }
}
