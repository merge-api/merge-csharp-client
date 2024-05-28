using System.Text.Json.Serialization;
using Merge.Client.Ticketing;
using OneOf;

#nullable enable

namespace Merge.Client.Ticketing;

public class AttachmentRequest
{
    /// <summary>
    /// The attachment's name. It is required to include the file extension in the attachment's name.
    /// </summary>
    [JsonPropertyName("file_name")]
    public string? FileName { get; init; }

    /// <summary>
    /// The ticket associated with the attachment.
    /// </summary>
    [JsonPropertyName("ticket")]
    public OneOf<string, Ticket>? Ticket { get; init; }

    /// <summary>
    /// The attachment's url. It is required to include the file extension in the file's URL.
    /// </summary>
    [JsonPropertyName("file_url")]
    public string? FileUrl { get; init; }

    /// <summary>
    /// The attachment's file format.
    /// </summary>
    [JsonPropertyName("content_type")]
    public string? ContentType { get; init; }

    /// <summary>
    /// The user who uploaded the attachment.
    /// </summary>
    [JsonPropertyName("uploaded_by")]
    public string? UploadedBy { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
