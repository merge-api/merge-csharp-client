using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm;

/// <summary>
/// # The Engagement Type Object
/// ### Description
/// The `Engagement Type` object is used to represent an interaction activity. A given `Engagement` typically has an `Engagement Type` object represented in the engagement_type field.
/// ### Usage Example
/// TODO
/// </summary>
public record EngagementType
{
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The engagement type's activity type.
    ///
    /// * `CALL` - CALL
    /// * `MEETING` - MEETING
    /// * `EMAIL` - EMAIL
    /// </summary>
    [JsonPropertyName("activity_type")]
    public ActivityTypeEnum? ActivityType { get; set; }

    /// <summary>
    /// The engagement type's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteField>? RemoteFields { get; set; }

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
