using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ticketing;

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
    /// The attachment's name. It is required to include the file extension in the attachment's name.
    /// </summary>
    [JsonPropertyName("file_name")]
    public string? FileName { get; set; }

    /// <summary>
    /// The ticket associated with the attachment.
    /// </summary>
    [JsonPropertyName("ticket")]
    public OneOf<string, Ticket>? Ticket { get; set; }

    /// <summary>
    /// The attachment's url. It is required to include the file extension in the file's URL.
    /// </summary>
    [JsonPropertyName("file_url")]
    public string? FileUrl { get; set; }

    /// <summary>
    /// The attachment's file format.
    /// </summary>
    [JsonPropertyName("content_type")]
    public string? ContentType { get; set; }

    /// <summary>
    /// The user who uploaded the attachment.
    /// </summary>
    [JsonPropertyName("uploaded_by")]
    public string? UploadedBy { get; set; }

    /// <summary>
    /// When the third party's attachment was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
