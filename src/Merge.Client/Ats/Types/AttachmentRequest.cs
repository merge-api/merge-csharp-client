using System.Text.Json.Serialization;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class AttachmentRequest
{
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

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
