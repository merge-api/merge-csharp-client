using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record Attachment
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
    /// The attachment's name.
    /// </summary>
    [JsonPropertyName("file_name")]
    public string? FileName { get; set; }

    /// <summary>
    /// The attachment's url.
    /// </summary>
    [JsonPropertyName("file_url")]
    public string? FileUrl { get; set; }

    /// <summary>
    ///
    /// </summary>
    [JsonPropertyName("candidate")]
    public string? Candidate { get; set; }

    /// <summary>
    /// The attachment's type.
    ///
    /// - `RESUME` - RESUME
    /// - `COVER_LETTER` - COVER_LETTER
    /// - `OFFER_LETTER` - OFFER_LETTER
    /// - `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("attachment_type")]
    public AttachmentTypeEnum? AttachmentType { get; set; }

    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }
}
