using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ticketing;

public record Viewer
{
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
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
