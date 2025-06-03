using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;
using OneOf;

namespace Merge.Ticketing;

/// <summary>
/// # The Viewer Object
/// ### Description
/// The `Viewer` object is used to represent a User or Team within a company.
///
/// ### Usage Example
/// TODO
/// </summary>
public record Viewer
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
    /// The Team this Viewer belongs to.
    /// </summary>
    [JsonPropertyName("team")]
    public OneOf<string, Team>? Team { get; set; }

    /// <summary>
    /// The User this Viewer belongs to.
    /// </summary>
    [JsonPropertyName("user")]
    public OneOf<string, User>? User { get; set; }

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
