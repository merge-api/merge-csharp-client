using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record AttachmentRequest
{
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

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }
}
