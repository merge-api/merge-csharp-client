using System.Text.Json.Serialization;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class Attachment
{
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

    /// <summary>
    /// The attachment's name.
    /// </summary>
    [JsonPropertyName("file_name")]
    public string? FileName { get; init; }

    /// <summary>
    /// The attachment's url.
    /// </summary>
    [JsonPropertyName("file_url")]
    public string? FileUrl { get; init; }

    /// <summary>
    ///
    /// </summary>
    [JsonPropertyName("candidate")]
    public string? Candidate { get; init; }

    /// <summary>
    /// The attachment's type.
    ///
    /// - `RESUME` - RESUME
    /// - `COVER_LETTER` - COVER_LETTER
    /// - `OFFER_LETTER` - OFFER_LETTER
    /// - `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("attachment_type")]
    public AttachmentTypeEnum? AttachmentType { get; init; }

    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
